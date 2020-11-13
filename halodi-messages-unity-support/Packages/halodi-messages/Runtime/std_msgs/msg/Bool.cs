using System.Text;
namespace std_msgs.msg
{


[System.Serializable]
public class Bool : Halodi.CDR.DataType<Bool>
{

	public Halodi.CDR.TopicDataType<Bool> Type => new BoolPubSubType();
	
   public bool data;


   public void Set(Bool other)
   {
      data = other.data;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("Bool {");
      builder.Append("data=");
      builder.Append(this.data);
      builder.Append("}");
      return builder.ToString();
   }
}


}