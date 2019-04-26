using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Recognition.SrgsGrammar;
//using Microsoft.Speech;
//using Microsoft.Speech.Recognition;


namespace WindowsFormsApplication1
{
    public partial class SpeechRecgn : Form
    {
        public SpeechRecgn()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
        
        }
        

    private void button1_Click(object sender, EventArgs e)
    
    {
        
        var recognizers = SpeechRecognitionEngine.InstalledRecognizers();
        SpeechRecognitionEngine recognizer = new SpeechRecognitionEngine();
        Choices colors = new Choices();
        colors.Add("red");
        colors.Add("green");
        colors.Add("blue");
        GrammarBuilder gb = new GrammarBuilder();
        gb.Append(colors);
        Grammar dictationGrammar = new Grammar(gb);
        recognizer.LoadGrammar(dictationGrammar);
        try
        {
            button1.Text = "Speak Now";
            recognizer.SetInputToDefaultAudioDevice();
            RecognitionResult result = recognizer.Recognize();
            button1.Text = result.Text;
        }
        catch (InvalidOperationException exception)
        {
            button1.Text = String.Format("Could not recognize input from default aduio device. Is a microphone or sound card available?\r\n{0} - {1}.", exception.Source, exception.Message);
        }
        finally
        {
            recognizer.UnloadAllGrammars();
        }        

    }

       
        }
    }

