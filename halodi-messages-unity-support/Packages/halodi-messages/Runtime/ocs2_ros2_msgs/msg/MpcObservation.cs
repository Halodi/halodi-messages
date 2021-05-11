using System.Text;
namespace ocs2_ros2_msgs.msg
{


[System.Serializable]
public class MpcObservation : Halodi.CDR.DataType<MpcObservation>
{

	public Halodi.CDR.TopicDataType<MpcObservation> Type => new MpcObservationPubSubType();
	
   public float time;
   public ocs2_ros2_msgs.msg.MpcState state;
   public ocs2_ros2_msgs.msg.MpcInput input;
   public byte mode;


   public void Set(MpcObservation other)
   {
      time = other.time;

      ocs2_ros2_msgs.msg.MpcStatePubSubType.Copy(other.state, state);

      ocs2_ros2_msgs.msg.MpcInputPubSubType.Copy(other.input, input);

      mode = other.mode;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("MpcObservation {");
      builder.Append("time=");
      builder.Append(this.time);      builder.Append(", ");
      builder.Append("state=");
      builder.Append(this.state);      builder.Append(", ");
      builder.Append("input=");
      builder.Append(this.input);      builder.Append(", ");
      builder.Append("mode=");
      builder.Append(this.mode);
      builder.Append("}");
      return builder.ToString();
   }
}


}