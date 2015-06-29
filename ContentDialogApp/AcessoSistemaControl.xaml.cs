using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace ContentDialogApp
{
    public sealed partial class AcessoSistemaControl : UserControl
    {
        public async static void AcessarSistema()
        {
            var acessar = new AcessoSistemaControl();
            ContentDialog dialogo = new ContentDialog();

            dialogo.PrimaryButtonText = "Acessar";
            dialogo.PrimaryButtonClick += Tela_PrimaryButtonClick;

            dialogo.SecondaryButtonText = "Cancelar";
            dialogo.SecondaryButtonClick += Tela_SecundaryButtonClick;


            dialogo.Title = "Acessar Sistema";

            dialogo.Content = "teste";

            await dialogo.ShowAsync();


        }

        private static void Tela_SecundaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            //throw new NotImplementedException();
        }

        private async static void Tela_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            var tela = sender.Content as AcessoSistemaControl;


            if (tela.textBoxUsuario.Text == "tiago" && tela.passwordBoxSenha.Password == "123456")
            {
            }
            else
            {
                args.Cancel = true;
                MessageDialog dialogo = new MessageDialog("usuário ou senha errados", "aviso");
                await dialogo.ShowAsync();

            }

        }

        public AcessoSistemaControl()
        {
            this.InitializeComponent();
        }

        private void hyperEsqueci_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
