using System;
using System.Windows.Forms;

namespace UrbanFarming.Desktop
{
    public partial class FormProduto : Form
    {
        public FormProduto()
        {
            InitializeComponent();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var codigo = textBoxCodigo.Text;
            var nome = textBoxNome.Text;
            var valor = textBoxValor.Text;
            var descricao = textBoxDescricao.Text;
            var linkImagem = textBoxLinkImagem.Text;

            // Aqui você pode adicionar a lógica para cadastrar o produto, como fazer uma chamada para uma API ou salvar em um banco de dados.
            MessageBox.Show($"Produto cadastrado:\nCódigo: {codigo}\nNome: {nome}\nValor: {valor}\nDescrição: {descricao}\nLink da Imagem: {linkImagem}");
        }
    }
}
