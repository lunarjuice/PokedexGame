public class Homework: PokedexItem {

        //states
        string shape;
        int words;
        bool foldAction;

        public Homework(string color, string shape, int words, bool foldAction): base(color) {
            this.shape = shape;
            this.words = words;
            this.foldAction = foldAction;
        }
        
        public string Shape{ get{ return shape;} set {shape = value; }}
        public int Words{ get{ return words;} set {words = value; }}
        public bool FoldAction{ get{ return foldAction;} set {foldAction = value; }}

        //behaviors
        public string getsCrumbled(){
            if (foldAction && words > 1 && shape =="circle") {
                return "This is someone's homework...I hope they're not missing it.";
            }
            return "This homework is still okay.";
        }
}
//change