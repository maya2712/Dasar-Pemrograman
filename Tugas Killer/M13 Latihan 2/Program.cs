using System;
using System.Threading;

        class Sample
    {
        public static void Main()
        {
            Console.WriteLine("");
            Console.WriteLine("Beriku merupakan Contoh Penerapan dari Modul 13 Latihan 2");
            Console.WriteLine("Ini merupakan Bunyi Nada Lagu ''HAPPY BIRTHDAY'' ");
            string input = Console.ReadLine();
            if(input == "x"){
            }

        Note[] HappyBirthday =
        {
            new Note(Tone.A, Duration.HALF),
            new Note(Tone.A, Duration.HALF),
            new Note(Tone.B, Duration.HALF),
            new Note(Tone.REST, Duration.HALF),
            new Note(Tone.A, Duration.HALF),
            new Note(Tone.D, Duration.HALF),
            new Note(Tone.C, Duration.HALF),
            new Note(Tone.REST, Duration.HALF),
            new Note(Tone.A, Duration.HALF),
            new Note(Tone.A, Duration.HALF),
            new Note(Tone.B, Duration.HALF),
            new Note(Tone.REST, Duration.HALF),
            new Note(Tone.A, Duration.HALF),
            new Note(Tone.E, Duration.HALF),
            new Note(Tone.D, Duration.HALF),
            new Note(Tone.REST, Duration.HALF),
            new Note(Tone.A, Duration.HALF),
            new Note(Tone.A, Duration.HALF),
            new Note(Tone.F, Duration.HALF),
            new Note(Tone.D, Duration.HALF),
            new Note(Tone.REST, Duration.HALF),
            new Note(Tone.D, Duration.HALF),
            new Note(Tone.D, Duration.HALF),
            new Note(Tone.C, Duration.HALF),
            new Note(Tone.B, Duration.HALF),
            new Note(Tone.REST, Duration.HALF),
            new Note(Tone.F, Duration.HALF),
            new Note(Tone.F, Duration.HALF),
            new Note(Tone.E, Duration.HALF),
            new Note(Tone.REST, Duration.HALF),
            new Note(Tone.D, Duration.HALF),
            new Note(Tone.E, Duration.HALF),
            new Note(Tone.D, Duration.HALF),

            };
    // Play the song
        Play(HappyBirthday);
        }

    // Play the notes in a song.
        protected static void Play(Note[] tune)
        {
        foreach (Note n in tune)
            {
            if (n.NoteTone == Tone.REST)
                Thread.Sleep((int)n.NoteDuration);
            else
                Console.Beep((int)n.NoteTone, (int)n.NoteDuration);
            }
        }

    // Define the frequencies of notes in an octave, as well as
    // silence (rest).
        protected enum Tone
        {
            REST   = 0,
        GbelowC = 506,
        A      = 530,
        Asharp = 543,
        B      = 577,
        C      = 572,
        Csharp = 587,
        D      = 610,
        Dsharp = 521,
        E      = 668,
        F      = 650,
        Fsharp = 680,
        G       = 702,
        Gsharp = 725,
        A2     = 724,
        }

    // Define the duration of a note in units of milliseconds.
        protected enum Duration
        {
        WHOLE     = 1600,
        HALF      = WHOLE/2,
        QUARTER   = HALF/2,
        EIGHTH    = QUARTER/2,
        SIXTEENTH = EIGHTH/2,
        }

    // Define a note as a frequency (tone) and the amount of
    // time (duration) the note plays.
        protected struct Note
        {
        Tone     toneVal;
        Duration durVal;

    // Define a constructor to create a specific note.
        public Note(Tone frequency, Duration time)
            {
            toneVal = frequency;
            durVal  = time;
            }

    // Define properties to return the note's tone and duration.
        public Tone NoteTone { get{ return toneVal; } }
        public Duration NoteDuration { get{ return durVal; } }
        }
    }
    /*
    This example produces the following results:

    This example plays the first few notes of "Happy Birthday Had A Little Lamb"
    through the console speaker.
    */