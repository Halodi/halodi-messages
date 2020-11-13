using System.Text;
namespace tf2_msgs.msg
{


[System.Serializable]
public class TFMessage : Halodi.CDR.DataType<TFMessage>
{

	public Halodi.CDR.TopicDataType<TFMessage> Type => new TFMessagePubSubType();
	
   public System.Collections.Generic.List<geometry_msgs.msg.TransformStamped> transforms;


   public void Set(TFMessage other)
   {

      if(other.transforms == null)
      {
      	transforms = null;
      }
      else
      {
      	transforms = new System.Collections.Generic.List<geometry_msgs.msg.TransformStamped>(other.transforms.Count);
      	for(int i1 = 0; i1 < other.transforms.Count; i1++)
      	{
      		if(other.transforms[i1] == null)
      		{
      			transforms.Add(null);
      		}
      		else
      		{
      			geometry_msgs.msg.TransformStamped newElement = geometry_msgs.msg.TransformStampedPubSubType.Create();
      	   		geometry_msgs.msg.TransformStampedPubSubType.Copy(other.transforms[i1], newElement);
      	   		transforms.Add(newElement);
      		}	}
      }   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("TFMessage {");
      builder.Append("transforms=");
      builder.Append(this.transforms);
      builder.Append("}");
      return builder.ToString();
   }
}


}