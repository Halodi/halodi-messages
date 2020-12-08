using System.Text;
namespace std_msgs.msg
{


[System.Serializable]
public class String : Halodi.CDR.DataType<String>
{

	public Halodi.CDR.TopicDataType<String> Type => new StringPubSubType();
	
   public string data;


   public void Set(String other)
   {
      data = other.data;
   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("String {");
      builder.Append("data=");
      builder.Append(this.data);
      builder.Append("}");
      return builder.ToString();
   }
}


}