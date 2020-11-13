using System.Text;
namespace std_msgs.msg
{


[System.Serializable]
public class UInt32 : Halodi.CDR.DataType<UInt32>
{

	public Halodi.CDR.TopicDataType<UInt32> Type => new UInt32PubSubType();
	
   public uint data;


   public void Set(UInt32 other)
   {
      data = other.data;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("UInt32 {");
      builder.Append("data=");
      builder.Append(this.data);
      builder.Append("}");
      return builder.ToString();
   }
}


}