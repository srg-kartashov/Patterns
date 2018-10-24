namespace Pattern2_Builder
{
    public enum Wheel { Summer, Winter, Universal };
    public enum Carcase { Sedan, Hatchback, Wagon };
    public enum Color { Black, White, Silver, Red, Blue, Purple };
    public enum Cabin { Leather, Suede, Wood, Carbon };

    class Car
    {
        public Wheel Wheel { get; set; }

        public Carcase Carcase { get; set; }

        public Color Color { get; set; }

        public Cabin Cabin { get; set; }
    }
}
