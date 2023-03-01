using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace FileOrganizer
{
    public partial class frm_OrganizeWindow : Form
    {
        public frm_OrganizeWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Quando marca o chackbox "Same to organize", obtem o mesmo texto contido no textbox e desabilita o botão "Browser" de "Folder to Save".
        /// Quando demarca o checkbox, ele limpa o campo "Folder to Sabe" e habilita o botão "Browser"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_SaveSameOrganize.Checked == true)
            {
               txt_PathSave.Text = txt_PathIn.Text;
               btn_BrowsePathSave.Enabled = false;
               txt_PathSave.ReadOnly = true;
               txt_PathSave.BackColor = Color.White;
            }

            if (ckb_SaveSameOrganize.Checked == false)
            {
                txt_PathSave.Text = string.Empty;
                btn_BrowsePathSave.Enabled = true;
                txt_PathSave.ReadOnly = false;
            }
        }

        /// <summary>
        /// Ao clicar no botão "Browser" de "Folder to Organize", abre uma janela para seleção de pasta e armazena a seleção no textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_BrowsePathIn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog pathIn = new FolderBrowserDialog();
            pathIn.ShowDialog();
            txt_PathIn.Text = pathIn.SelectedPath;
            if (ckb_SaveSameOrganize.Checked)
            {
                txt_PathSave.Text = txt_PathIn.Text;
            }
        }

        /// <summary>
        /// Ao clicar no botão "Browser" de "Folder to Save", abre uma janela para seleção de pasta e armazena a seleção no textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_BrowsePathSave_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog pathSave = new FolderBrowserDialog();
            pathSave.ShowDialog();
            txt_PathSave.Text = pathSave.SelectedPath;  
            
        }

        /// <summary>
        /// Encerra a aplicação.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Lista todos os arquivos que serão organizados de acordo com a pasta e as extensões selecionadas.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //Valida se a pasta de origem está preenchida.
            if (txt_PathIn.Text == string.Empty)
            {
                MessageBox.Show("Please Select a Folder to List Files!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Valida se a pasta de origem existe.
            if (!ValidatePath(txt_PathIn.Text))
            {
                MessageBox.Show("Folder to Organize Doesn't Exist!\r\n\r\nPlease Select a Valid Folder!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Valida se ha algum checkbox de extensão selecionado.
            bool validate_Checkboxs = false;
            foreach (CheckBox c in this.Controls.OfType<CheckBox>())
            {
                if (c.Checked & c.Name != "ckb_SaveSameOrganize")
                {
                    validate_Checkboxs = true;
                }
            }

            //Se não houver nenhuma seleção de extensão, avisa na tela.
            if (!validate_Checkboxs)
            {
                MessageBox.Show("Please Select at Least One Extension or Check 'All Files in Folder'!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Criando listas para os arquivos e para as extensões.
            List<string> files = new List<string>();
            List<string> extensions = new List<string>();

            //Se "All Files in Folder" estiver selecionado, armazena a extensão "*.*" na lista,
            //caso não, percorre para validar quais extensões estão marcadas.
            if (ckb_All.Checked == true)
            {
                extensions.Add("*.*");
            }
            else
            {
                foreach (CheckBox ckb in this.Controls.OfType<CheckBox>())
                {
                    if (ckb.Checked & ckb.Name != "ckb_SaveSameOrganize")
                    {
                        string extension = GetExtension(ckb);

                        if (ckb.Name == "ckb_Jpeg")
                        {
                            extensions.Add(extension);
                            extensions.Add("*.jpg*");
                        }
                        else
                        {
                            extensions.Add(extension);
                        }
                        
                    }
                }
            }

            //Para cada extensão armazenada na lista, seleciona os caminhos dos arquivos que serão organizados.
            foreach (string ext in extensions)
            {
                List<string> filesTemp = GetList(txt_PathIn.Text, ext);
                files.AddRange(filesTemp);
            }

            //Para cada caminho completo armazenado, pega apenas o nome do arquivo para ser exibido.
            List<string> names = new List<string>();
            foreach (string f in files)
            {
                FileInfo info = new FileInfo(f);
                names.Add(info.Name);                   
            }

            //Popula a listbox com os nomes dos arquivos que serão organizados.
            lst_Files.DataSource = names;

            if (files.Count() == 0)
            {
                MessageBox.Show("No files found!");
            }
            else
            {
                MessageBox.Show(files.Count().ToString() + " file(s) will be organized!");
            }

        }

        /// <summary>
        /// Organiza os arquivos em pasta separadas por data de criação.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Organize_Click(object sender, EventArgs e)
        {
            //Valida se a pasta de origem está preenchida.
            if (txt_PathIn.Text == string.Empty)
            {
                MessageBox.Show("Please Select a Folder to Organize!","", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            //Valida se a pasta de origem existe.
            if (!ValidatePath(txt_PathIn.Text))
            {
                string message = "Folder to Organize Doesn't Exist!\r\n\r\nPlease Select a Valid Folder!";
                MessageBox.Show(message,"",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            //Valida se a pasta de destino está preenchida.
            if (txt_PathSave.Text == string.Empty)
            {
                MessageBox.Show("Please Select a Folder to Save the Files!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            //Valida se a opção de Mover ou Copiar está preenchida.
            if (cmb_MoveCopy.Text == string.Empty)
            {
                MessageBox.Show("Please Select to Move or Copy the Files!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Valida se ha algum checkbox de extensão selecionado.
            bool validate_Checkboxs = false;
            foreach (CheckBox c in this.Controls.OfType<CheckBox>())
            {
                if (c.Checked & c.Name != "ckb_SaveSameOrganize")
                {
                    validate_Checkboxs = true;
                }
            }

            //Se não houver nenhuma marcada, avisa na tela.
            if (!validate_Checkboxs)
            {
                MessageBox.Show("Please Select at Least One Extension or Check 'All Files in Folder'!","", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Criando as variáveis com os caminhos selecionados, se os arquivos serão movidos ou copiados e a lista de extensões.
            string pathToOrganize = txt_PathIn.Text;
            string pathToSave = txt_PathSave.Text;
            string saveMode = cmb_MoveCopy.Text;
            List<string> extensions = new List<string>();

            //Se "All Files in Folder" estiver selecionado, armazena a extensão "*.*" na lista,
            //caso não, percorre para validar quais extensões estão marcadas.
            if (ckb_All.Checked == true)
            {
                extensions.Add("*.*");
            }
            else
            {
                foreach (CheckBox ckb in this.Controls.OfType<CheckBox>())
                {
                    if (ckb.Checked & ckb.Name != "ckb_SaveSameOrganize")
                    {
                        string extension = GetExtension(ckb);

                        if (ckb.Name == "ckb_Jpeg")
                        {
                            extensions.Add(extension);
                            extensions.Add("*.jpg*");
                        }
                        else
                        {
                            extensions.Add(extension);
                        }
                    }
                }
            }

            //Para cada extensão armazenada na lista, seleciona os caminhos dos arquivos que serão organizados.
            List<string> files = new List<string>();
            foreach (string ext in extensions)
            {
                List<string> filesTemp = GetList(txt_PathIn.Text, ext);
                files.AddRange(filesTemp);
            }

            //Para cada arquivo presente na lista, move ou copia para a pasta de destino.
            foreach (string f in files)
            {
                if (saveMode == "Move")
                {
                    MoveFile(f, txt_PathSave.Text);
                }

                if (saveMode == "Copy")
                {
                    CopyFile(f, txt_PathSave.Text);
                }

            }

            //Mostra quantos arquivos foram organizados.
            MessageBox.Show("Congratulations!" + "\r\n\r\n" + files.Count() + " file(s) have been organized!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        /// <summary>
        /// Obtém a lista de arquivos que serão organizados de acordo com as extensões e o caminho de origem.
        /// </summary>
        /// <param name="folderPath">Pasta de origem do arquivos.</param>
        /// <param name="extension">Extensão do arquivo.</param>
        /// <returns>Lista de string com os caminhos completos dos arquivos</returns>
        static List<string> GetList(string folderPath, string extension)
        {  
            var files = System.IO.Directory.GetFiles(@folderPath, extension, System.IO.SearchOption.TopDirectoryOnly).Where(file => !Regex.IsMatch(Path.GetFileName(file), @"desktop.ini", RegexOptions.IgnoreCase));
            return files.ToList();
        }
        
        /// <summary>
        /// Obtém as informações de cada arquivo que serão organizados.
        /// </summary>
        /// <param name="filePath">Caminho do arquivo</param>
        /// <returns>FileInfo do arquivo</returns>
        static FileInfo GetFileInfo(string filePath)
        {
            return new FileInfo(@filePath);
        }

        /// <summary>
        /// Obtém a data de criação dos arquivos.
        /// </summary>
        /// <param name="file">Arquivo.</param>
        /// <returns>Data de criação do arquivo</returns>
        private static Regex r = new Regex(":");
        static DateTime GetDate(string file)
        {
            FileInfo fileInfo = new FileInfo(@file);
            string dateTaken = string.Empty;
            DateTime date = new DateTime();

            //Pega a data de quando a foto foi tirada, caso não há, pega a data de modificação
     
            try
            {
                using (FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read))
                using (Image myImage = Image.FromStream(fs, false, false))
                {

                    PropertyItem propItem = myImage.GetPropertyItem(36867);
                    dateTaken = r.Replace(Encoding.UTF8.GetString(propItem.Value), "-", 2);
                }
            }

            catch { }
            finally
            {

                if (dateTaken != string.Empty)
                {
                    date = DateTime.Parse(dateTaken);
                }
                else
                {
                    date = fileInfo.LastWriteTime;
                }
            }
                          

        return date;           
            
        }

        /// <summary>
        /// Cria o caminho que onde o item será movido/copiado.
        /// </summary>
        /// <param name="filePath">Caminho do arquivo.</param>
        /// <returns>Caminho de acordo com as datas dos arquivos</returns>
        static string GetFolderPath(string filePath)
        {
            DateTime fileInfo = GetDate(filePath);
            string pathToSave = fileInfo.ToString("yyyy") + "\\" + fileInfo.ToString("yyyy-MM-dd");
            return pathToSave;

        }

        /// <summary>
        /// Move o arquivo de acordo com pasta destino e a data de criação do arquivo.
        /// </summary>
        /// <param name="file">Arquivo.</param>
        /// <param name="toSave">Pasta de destino.</param>
        static void MoveFile(string file, string toSave)
        {
            string pathToSave = toSave + "\\" + GetFolderPath(file);
            bool validatePathExist = System.IO.Directory.Exists(@pathToSave);

            //Valida se o caminho não existe.
            if (!validatePathExist)
            {
                System.IO.Directory.CreateDirectory(pathToSave);
            }

            //Move o arquivo
            FileInfo fileInfo = new FileInfo(@file);
            System.IO.File.Move(file, pathToSave + "\\" + fileInfo.Name.ToString());

        }

        /// <summary>
        /// Copia o arquivo de acordo com pasta destino e a data de criação do arquivo.
        /// </summary>
        /// <param name="file">Arquivo.</param>
        /// <param name="toSave">Pasta de destino</param>
        static void CopyFile(string file, string toSave)
        {
            string pathToSave = toSave + "\\" + GetFolderPath(file);
            bool validatePathExist = System.IO.Directory.Exists(@pathToSave);

            //Valida se o caminho não existe.
            if (!validatePathExist)
            {
                System.IO.Directory.CreateDirectory(pathToSave);
            }

            //Copia o arquivo.
            FileInfo fileInfo = new FileInfo(@file);
            System.IO.File.Copy(file, pathToSave + "\\" + fileInfo.Name.ToString());

        }


        /// <summary>
        /// Desabilita ou habilita os chackboxs das extensões ao marcar/desmarcar "All Files in Folder".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ckb_All_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_All.Checked)
            {
                foreach (CheckBox c in this.Controls.OfType<CheckBox>())
                {
                    if (c.Name != "ckb_All" & c.Name != "ckb_SaveSameOrganize")
                    {
                        c.Enabled = false;     
                        c.Checked = false;
                        
                    }
                }
            }
            if (!ckb_All.Checked)
            {
                foreach (CheckBox c in this.Controls.OfType<CheckBox>())
                {
                    if (c.Name != "ckb_All" & c.Name != "ckb_SaveSameOrganize")
                    {
                        c.Enabled = true;
                        c.Checked = false;
                    }
                }
            }
        }

        /// <summary>
        /// Valida de um diretório existe.
        /// </summary>
        /// <param name="path">Diretório</param>
        /// <returns>Booleano se o diretótio existe</returns>
        static bool ValidatePath(string path) 
        {
            bool valid = Directory.Exists(path);
            return valid;
        }

        /// <summary>
        /// Obtém a extensão de acordo com o checkbox.
        /// </summary>
        /// <param name="ckb">Checkbox</param>
        /// <returns>Um extensão</returns>
        static string GetExtension(CheckBox ckb)
        {
            string extension = ckb.Name.Substring(4).ToLower();
            extension = "*." + extension + "*";
            return extension;
        }

        private void lbl_Extensions_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_PathIn_Click(object sender, EventArgs e)
        {

        }
    }    
}
