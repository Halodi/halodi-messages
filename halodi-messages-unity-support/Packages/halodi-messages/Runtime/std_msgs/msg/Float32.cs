using System.Text;
namespace std_msgs.msg
{


[System.Serializable]
public class Float32 : Halodi.CDR.DataType<Float32>
{

	public Halodi.CDR.TopicDataType<Float32> Type => new Float32PubSubType();
	
   public float data;


   public void Set(Float32 other)
   {
      data = other.data;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("Float32 {");
      builder.Append("data=");
      builder.Append(this.data);
      builder.Append("}");
      return builder.ToString();
   }
}


}