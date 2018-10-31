using System;
using System.Drawing;
using Spire.Doc;
using Spire.Doc.Documents;

namespace Senai.ManipulacaoWORD {
    class Program {
        static void Main (string[] args) {
            string nome, cpf;

            // Recebendo o nome para o Certificado
            System.Console.WriteLine ("Informe seu nome completo:");
            nome = Console.ReadLine ();

            // Recebendo CPF do usuário
            System.Console.WriteLine ("Informe o seu CPF:");
            cpf = Console.ReadLine ();

            // Limpando a tela

            Console.Clear ();

            Document doc = new Document ();

            Section section = doc.AddSection ();

            Paragraph title = section.AddParagraph ();

            title.AppendText ("CERTIFICADO");

            ParagraphStyle s1 = new ParagraphStyle (doc);

            s1.Name = "TitleTextColor";

            s1.CharacterFormat.TextColor = Color.Blue;

            s1.CharacterFormat.FontName = "Arial";
            // s1.CharacterFormat.FontName = "Algerian";

            s1.CharacterFormat.FontSize = 30;

            title.Format.HorizontalAlignment = HorizontalAlignment.Justify;

            doc.Styles.Add (s1);
            title.ApplyStyle (s1.Name);

            Paragraph texto = section.AddParagraph ();

            texto.AppendText ($@"Certificamos que {nome}, portador(a) do CPF '{cpf}', está apto a utilizar a Spire.Doc para a manipulação de arquivos WORD.");

            doc.Styles.Add(s1);

            texto.ApplyStyle(s1.Name);

            System.Console.WriteLine("Certificado obtido com sucesso!");

            // doc.SaveToFile(@"C:\Users\33747821839\Desktop\Certificado.docx");
            doc.SaveToFile("Certificado.docx");
        }
    }
}