using System.Text;
namespace std_msgs.msg
{


[System.Serializable]
public class UInt8 : Halodi.CDR.DataType<UInt8>
{

	public Halodi.CDR.TopicDataType<UInt8> Type => new UInt8PubSubType();
	
   public byte data;


   public void Set(UInt8 other)
   {
      data = other.data;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("UInt8 {");
      builder.Append("data=");
      builder.Append(this.data);
      builder.Append("}");
      return builder.ToString();
   }
}


}