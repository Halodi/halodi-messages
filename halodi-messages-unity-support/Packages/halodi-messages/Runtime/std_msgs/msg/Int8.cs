using System.Text;
namespace std_msgs.msg
{


[System.Serializable]
public class Int8 : Halodi.CDR.DataType<Int8>
{

	public Halodi.CDR.TopicDataType<Int8> Type => new Int8PubSubType();
	
   public byte data;


   public void Set(Int8 other)
   {
      data = other.data;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("Int8 {");
      builder.Append("data=");
      builder.Append(this.data);
      builder.Append("}");
      return builder.ToString();
   }
}


}