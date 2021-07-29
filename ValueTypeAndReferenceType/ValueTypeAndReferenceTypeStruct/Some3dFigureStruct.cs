namespace ValueTypeAndReferenceTypeStruct
{
    struct Some3dFigureStruct
    {
        public int NumEdges { get; set; }
        public double LengthEdges { get; set; }
        public double AreaFigure { get; set; }

        public Some3dFigureStruct(int numEdges, int lengthEdges) => (NumEdges, LengthEdges, AreaFigure) = (numEdges, lengthEdges, 0);
    }
}
