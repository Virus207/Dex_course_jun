namespace ValueTypeAndReferenceType
{
    class Some3dFigure
    {
        public int NumEdges { get; set; }
        public double LengthEdges { get; set; }
        public double AreaFigure { get; set; }

        public Some3dFigure(int numEdges, int lengthEdges) => (NumEdges, LengthEdges, AreaFigure) = (numEdges, lengthEdges, 0);
    }
}
