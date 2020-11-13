using System.Text;
namespace rcl_interfaces.msg
{


[System.Serializable]
public class IntraProcessMessage : Halodi.CDR.DataType<IntraProcessMessage>
{

	public Halodi.CDR.TopicDataType<IntraProcessMessage> Type => new IntraProcessMessagePubSubType();
	
   public ulong publisher_id;
   public ulong message_sequence;


   public void Set(IntraProcessMessage other)
   {
      publisher_id = other.publisher_id;

      message_sequence = other.message_sequence;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("IntraProcessMessage {");
      builder.Append("publisher_id=");
      builder.Append(this.publisher_id);      builder.Append(", ");
      builder.Append("message_sequence=");
      builder.Append(this.message_sequence);
      builder.Append("}");
      return builder.ToString();
   }
}


}