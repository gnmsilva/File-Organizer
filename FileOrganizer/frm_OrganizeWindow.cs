using System;
using System.Collections;
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
        private void btn_ListFiles_Click(object sender, EventArgs e)
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
            foreach (CheckBox c in gbExtensions.Controls.OfType<CheckBox>())
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
                foreach (CheckBox ckb in gbExtensions.Controls.OfType<CheckBox>())
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

            //Valida se foi selecionado alguma opção em Folder Organization
            if (lst_FoldersIncluded.Items.Count == 0 && !ckb_CreateFileOrganizerFolder.Checked)
            {
                MessageBox.Show("Please Select at Least One Option in 'Folder Organization'!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Valida se ha algum checkbox de extensão selecionado.
            bool validate_Checkboxs = false;
            foreach (CheckBox c in gbExtensions.Controls.OfType<CheckBox>())
            {
                if (c.Checked)
                {
                    validate_Checkboxs = true;
                    break;
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
                foreach (CheckBox ckb in gbExtensions.Controls.OfType<CheckBox>())
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
                    MoveFile(f, txt_PathSave.Text, lst_FoldersIncluded, ckb_CreateFileOrganizerFolder);
                }

                if (saveMode == "Copy")
                {
                    CopyFile(f, txt_PathSave.Text, lst_FoldersIncluded, ckb_CreateFileOrganizerFolder);
                }

            }

            //Mostra quantos arquivos foram organizados.
            MessageBox.Show("Congratulations!" + "\r\n\r\n" + files.Count() + " file(s) have been organized!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        /// <summary>
        /// Altera para cima a posição do item selecionado 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_UpFolder_Click(object sender, EventArgs e)
        {
                MoveItem(-1, lst_FoldersIncluded);
        }

        /// <summary>
        /// Altera para baixo a posição do item selecionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_DownFolder_Click(object sender, EventArgs e)
        {
                MoveItem(1, lst_FoldersIncluded);
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
        static string GetFolderPath(string filePath, ListBox foldersIncluded, CheckBox fileOrganizerFolder)
        {
            string pathToSave = string.Empty;

            if (fileOrganizerFolder.Checked)
            {
                pathToSave += "FileOrganizer" + "\\";
            }

            for (int i = 0; i < foldersIncluded.Items.Count; i++)
            {
                if (foldersIncluded.Items[i].ToString() == "Date")
                {
                    DateTime fileInfo = GetDate(filePath);
                    pathToSave += fileInfo.ToString("yyyy") + "\\" + fileInfo.ToString("yyyy-MM-dd") + "\\";
                }

                if (foldersIncluded.Items[i].ToString() == "Extension")
                {
                    FileInfo fileInfo = new FileInfo(filePath);
                    pathToSave += fileInfo.Extension.Replace(".", string.Empty) + "\\";
                }

            }

            return pathToSave;

        }

        /// <summary>
        /// Move o arquivo de acordo com pasta destino e a data de criação do arquivo.
        /// </summary>
        /// <param name="file">Arquivo.</param>
        /// <param name="toSave">Pasta de destino.</param>
        static void MoveFile(string file, string toSave, ListBox foldersIncluded, CheckBox fileOrganizerFolder)
        {
            string pathToSave = toSave + "\\" + GetFolderPath(file, foldersIncluded, fileOrganizerFolder);
            bool validatePathExist = System.IO.Directory.Exists(@pathToSave);

            //Valida se o caminho não existe.
            if (!validatePathExist)
            {
                System.IO.Directory.CreateDirectory(pathToSave);
            }

            //Move o arquivo
            FileInfo fileInfo = new FileInfo(@file);
            System.IO.File.Move(file, pathToSave + fileInfo.Name.ToString());

        }

        /// <summary>
        /// Copia o arquivo de acordo com pasta destino e a data de criação do arquivo.
        /// </summary>
        /// <param name="file">Arquivo.</param>
        /// <param name="toSave">Pasta de destino</param>
        static void CopyFile(string file, string toSave, ListBox foldersIncluded, CheckBox fileOrganizerFolder)
        {
            string pathToSave = toSave + "\\" + GetFolderPath(file, foldersIncluded, fileOrganizerFolder);
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
                foreach (CheckBox c in gbExtensions.Controls.OfType<CheckBox>())
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
                foreach (CheckBox c in gbExtensions.Controls.OfType<CheckBox>())
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
        /// Adiciona o tipo de pasta selecionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AddExtension_Click(object sender, EventArgs e)
        {
            AddExtensions(lst_FoldersIncluded, lst_FoldersNotIncluded);
        }

        /// <summary>
        /// Remove o tipo de pasta selecionado e reordena por ordem alfabética
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_RemoveExtension_Click(object sender, EventArgs e)
        {
            RemoveExtensions(lst_FoldersIncluded, lst_FoldersNotIncluded);

            lst_FoldersNotIncluded.Sorted = true;

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

        /// <summary>
        /// Adiciona um item de uma ListBox para outra
        /// </summary>
        /// <param name="includedList">ListBox onde o item será incluso</param>
        /// <param name="notIncludedList">ListBox onde o item está</param>
        static void AddExtensions(ListBox includedList, ListBox notIncludedList)
        {
            foreach (var item in new ArrayList(notIncludedList.SelectedItems))
            {
                notIncludedList.Items.Remove(item);
                includedList.Items.Add(item);
            }
        }

        /// <summary>
        /// Remove um item de uma ListBox para outra
        /// </summary>
        /// <param name="includedList">ListBox onde o item está</param>
        /// <param name="notIncludedList">ListBox onde o item será colocado</param>
        static void RemoveExtensions(ListBox includedList, ListBox notIncludedList)
        {
            foreach (var item in new ArrayList(includedList.SelectedItems))
            {
                includedList.Items.Remove(item);
                notIncludedList.Items.Add(item);    
            }
        }

        /// <summary>
        /// Move um item de acordo com a direção informada dentro de uma ListBox
        /// </summary>
        /// <param name="direction">Se será acrescetado ou reduzido o index do item</param>
        public void MoveItem(int direction, ListBox folderIncluded)
        {
            if (folderIncluded.SelectedItem == null || folderIncluded.SelectedIndex < 0)
            {
                return;
            }

            int newIndex = folderIncluded.SelectedIndex + direction;

            if (newIndex < 0 || newIndex >= folderIncluded.Items.Count)
            {
                return;
            }

            object selected = folderIncluded.SelectedItem;

            folderIncluded.Items.Remove(selected);
            folderIncluded.Items.Insert(newIndex, selected);
            folderIncluded.SetSelected(newIndex, true);

        }
    }    
}
