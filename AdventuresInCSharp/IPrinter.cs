namespace AdventuresInCSharp {
    public interface IPrinter {
        bool CursorVisible { get; set; }
        void AlignCursorUnderPrevious();
        void AlignCursorCenter();
        void Clear();
        string GetUserInput();
        void PlaySoundBeep();
        void SetBackgroundBlack();
        void SetBackgroundWhite();
        void WaitForUser();
        void WriteLine(string s);
        void WriteLine(string s, TextAlign align);
        void WriteLineByCharacter(string s, TextAlign align);
    }
}
