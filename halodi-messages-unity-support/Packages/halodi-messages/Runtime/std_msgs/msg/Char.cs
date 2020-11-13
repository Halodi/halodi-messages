using System.Text;
namespace std_msgs.msg
{


[System.Serializable]
public class Char : Halodi.CDR.DataType<Char>
{

	public Halodi.CDR.TopicDataType<Char> Type => new CharPubSubType();
	
   public char data;


   public void Set(Char other)
   {
      data = other.data;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("Char {");
      builder.Append("data=");
      builder.Append(this.data);
      builder.Append("}");
      return builder.ToString();
   }
}


}