namespace FormularioTeste
{
    public partial class Form1 : Form
    {
        String login;
        String senha;
        String status;
        String tipo;
        String data;
        String perfil;
        String obs;
        String modulos;

        List<CheckBox> mod = new List<CheckBox>();
        public Form1()
        {
            
            InitializeComponent();
            mod.Add(cbCompras);
            mod.Add(cbBiblioteca);
            mod.Add(cbAcademico);
            mod.Add(cbDocumentacao);
            mod.Add(cbRH);
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            //COLETANDO DADOS DO FORMULARIOS, INSERIDOS NOS TEXTBOX, RADIOBUTTON, COMBOBOX E CHECKBOX.
            login = txtLogin.Text;
            senha = txtSenha.Text;
            status = cbStatus.Text;
            tipo = groupBox1.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text; //PEGAR O RADIOBUTTON SELECIONADO
            data = txtData.Text;
            perfil = groupBox2.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text;
            obs = txtObs.Text;

            modulos = "";

           //USANDO O FOREACH PARA COLETAR DADOS DO CHECKBOX UTILIZANDO UMA LISTA.

            foreach(CheckBox t in mod){ 
                if (t.Checked){
                    modulos += t.Text + ", ";
                }
            
            }


            FormUsuario formUsuario = new FormUsuario(login, senha, status, tipo, data, perfil, obs, modulos);
            formUsuario.Show();

            //MessageBox.Show(login + " " + senha + " " + status + "" + tipo + "" + data + "" + perfil + " " + modulos);
            
        }

    }
}