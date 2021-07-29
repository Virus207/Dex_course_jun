namespace ValueTypeAndReferenceTypeClass
{
    class Some3dFigureClass
    {
        public int NumEdges { get; set; }
        public double LengthEdges { get; set; }
        public double AreaFigure { get; set; }

        public Some3dFigureClass(int numEdges, int lengthEdges) => (NumEdges, LengthEdges, AreaFigure) = (numEdges, lengthEdges, 0);
    }
}
