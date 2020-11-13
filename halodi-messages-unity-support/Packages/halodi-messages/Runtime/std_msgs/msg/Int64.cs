using System.Text;
namespace std_msgs.msg
{


[System.Serializable]
public class Int64 : Halodi.CDR.DataType<Int64>
{

	public Halodi.CDR.TopicDataType<Int64> Type => new Int64PubSubType();
	
   public long data;


   public void Set(Int64 other)
   {
      data = other.data;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("Int64 {");
      builder.Append("data=");
      builder.Append(this.data);
      builder.Append("}");
      return builder.ToString();
   }
}


}