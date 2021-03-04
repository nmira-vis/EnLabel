namespace EnLabel
{
    internal class LabelPicture
    {
        private string label;
        private string newPathPicture;
        private int indexCounter = -1;

        public string Label { get => label; set => label = value; }
        public int IndexCounter { get => indexCounter; set => indexCounter = value; }
        public string NewPathPicture { get => newPathPicture; set => newPathPicture = value; }

        public LabelPicture(int counter, string label = "", string newPathPicture = "")
        {
            this.Label = label;
            this.IndexCounter = counter;
            this.NewPathPicture = newPathPicture;
        }
    }
}