namespace Animal_Shelter.Models
{
  public class Animal
  {
    public int AnimalId { get; set; }
    public string Type { get; set; }
    public string Name { get; set; }
    public System.DateTime DOA { get; set; }
    public string Breed { get; set; }

    public Animal()
    {
      DOA = System.DateTime.Now;
    }
  }
}