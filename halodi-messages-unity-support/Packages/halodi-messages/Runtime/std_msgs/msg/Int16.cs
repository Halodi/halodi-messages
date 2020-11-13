using System.Text;
namespace std_msgs.msg
{


[System.Serializable]
public class Int16 : Halodi.CDR.DataType<Int16>
{

	public Halodi.CDR.TopicDataType<Int16> Type => new Int16PubSubType();
	
   public short data;


   public void Set(Int16 other)
   {
      data = other.data;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("Int16 {");
      builder.Append("data=");
      builder.Append(this.data);
      builder.Append("}");
      return builder.ToString();
   }
}


}