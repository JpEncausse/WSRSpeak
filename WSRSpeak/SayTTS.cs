using System;
using System.Speech.Synthesis;

namespace encausse.net {
    class SayTTS {

        // -----------------------------------------
        //  MAIN
        // -----------------------------------------

        static void Main(string[] args) {
            if (args.Length != 1) {
                Console.WriteLine("Usage: SayTTS.exe \"text to speech\"");
                return;
            }
            say(args[0]);
        }

        public static void say(String tts) {
            Console.WriteLine("[TTS] Say: {0}", tts);
            using (SpeechSynthesizer synthesizer = new SpeechSynthesizer()) {

                // Configure the audio output.
                synthesizer.SetOutputToDefaultAudioDevice();

                // Build and speak a prompt.
                PromptBuilder builder = new PromptBuilder();
                builder.AppendText(tts);
                synthesizer.Speak(builder);
            }
        }
    }
}