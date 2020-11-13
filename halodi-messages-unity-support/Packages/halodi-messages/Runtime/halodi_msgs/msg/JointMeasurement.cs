using System.Text;
namespace halodi_msgs.msg
{


/**
          * Measurements for a single joint
          *
          *
          * Not using sensor_msgs::msg::JointState to avoid name lookups
          * 
          * Called JointMeasurement instead of JointState, to avoid confusing with sensor_msgs::msg::JointState.
          *
          */
[System.Serializable]
public class JointMeasurement : Halodi.CDR.DataType<JointMeasurement>
{

	public Halodi.CDR.TopicDataType<JointMeasurement> Type => new JointMeasurementPubSubType();
	
   public halodi_msgs.msg.JointName joint;
   /**
                 * Current measured joint position (rad for revolute, meter for prismatic)
                 *
                 * Note: This is the processed position the whole body controller uses internally
                 *
                 */
   public double position;
   /**
                 * Current measured joint velocity (rad/s for revolute, meter/s for prismatic)
                 *
                 * Note: This is the processed position the whole body controller uses internally
                 */
   public double velocity;
   /**
                 *
                 * Current measured effort (Nm for revolute, N for prismatic)
                 * 
                 * Note: This measurement is quite noisy and currently not implemented for all joints. It is recommeded to use desiredEffort for haptic feedback applications.
                 *
                 */
   public double measuredEffort;
   /**
                 *
                 * Current desired effort (Nm for revolute, N for prismatic)
                 *
                 * Note: This value has less noise than the measured effort and is recommeded to use for haptic feedback applications. With a low gear ratio, the desired and measured effort should be comparable.
                 *
                 */
   public double desiredEffort;


   public void Set(JointMeasurement other)
   {
      halodi_msgs.msg.JointNamePubSubType.Copy(other.joint, joint);

      position = other.position;

      velocity = other.velocity;

      measuredEffort = other.measuredEffort;

      desiredEffort = other.desiredEffort;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("JointMeasurement {");
      builder.Append("joint=");
      builder.Append(this.joint);      builder.Append(", ");
      builder.Append("position=");
      builder.Append(this.position);      builder.Append(", ");
      builder.Append("velocity=");
      builder.Append(this.velocity);      builder.Append(", ");
      builder.Append("measuredEffort=");
      builder.Append(this.measuredEffort);      builder.Append(", ");
      builder.Append("desiredEffort=");
      builder.Append(this.desiredEffort);
      builder.Append("}");
      return builder.ToString();
   }
}


}