using System.Text;
namespace std_msgs.msg
{


[System.Serializable]
public class UInt16 : Halodi.CDR.DataType<UInt16>
{

	public Halodi.CDR.TopicDataType<UInt16> Type => new UInt16PubSubType();
	
   public ushort data;


   public void Set(UInt16 other)
   {
      data = other.data;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("UInt16 {");
      builder.Append("data=");
      builder.Append(this.data);
      builder.Append("}");
      return builder.ToString();
   }
}


}