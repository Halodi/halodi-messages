using System.Text;
namespace halodi_msgs.msg
{


/**
         *
         * Null space configuration for joint in task space control mode
         *
         */
[System.Serializable]
public class JointNullSpaceConfiguration : Halodi.CDR.DataType<JointNullSpaceConfiguration>
{

	public Halodi.CDR.TopicDataType<JointNullSpaceConfiguration> Type => new JointNullSpaceConfigurationPubSubType();
	
   /**
                * Name of joint, required.
                */
   public halodi_msgs.msg.JointName joint;
   /**
                * Desired joint angle in the nullspace configuration
                *
                */
   public double q_nullspace;


   public void Set(JointNullSpaceConfiguration other)
   {
      halodi_msgs.msg.JointNamePubSubType.Copy(other.joint, joint);

      q_nullspace = other.q_nullspace;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("JointNullSpaceConfiguration {");
      builder.Append("joint=");
      builder.Append(this.joint);      builder.Append(", ");
      builder.Append("q_nullspace=");
      builder.Append(this.q_nullspace);
      builder.Append("}");
      return builder.ToString();
   }
}


}