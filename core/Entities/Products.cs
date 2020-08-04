namespace core.Entities
{
  public  class Products :EntityBase
    {
       public string   NamePro { get; set; }
        public  string Description { get; set; }
        public string  ImagePro { get; set; }         
        public decimal Price { get; set; }
        public decimal Decount { get; set; }
        public int Quetity  { get; set; }
        public Categorys Category { get; set; }
        public Groups Group { get; set; }

    }
}
