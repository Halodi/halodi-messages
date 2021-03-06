using System.Text;
namespace std_msgs.msg
{


[System.Serializable]
public class Byte : Halodi.CDR.DataType<Byte>
{

	public Halodi.CDR.TopicDataType<Byte> Type => new BytePubSubType();
	
   public byte data;


   public void Set(Byte other)
   {
      data = other.data;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("Byte {");
      builder.Append("data=");
      builder.Append(this.data);
      builder.Append("}");
      return builder.ToString();
   }
}


}