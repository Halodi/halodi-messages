using System.Text;
namespace halodi_msgs.msg
{


/**
          * Status of a joint
          *
          */
[System.Serializable]
public class JointStatus
{
   /**
                * Unique identifier for the joint
                * 
                */
   public halodi_msgs.msg.JointName joint;
   /**
                * Current status level of the joint
                *
                * As described in diagnostic_msgs/DiagnosticStatus
                *
                */
   public byte status_level;
   /**
                *
                * True if the motor is critical for balance. A failure in this joint will lead to the robot falling.
                *
                */
   public bool critical_for_balance;
   /**
                *
                * A fault has been detected in the output encoder and the joint is using the motor encoders as fallback
                *
                */
   public bool output_encoder_fault;
   /**
                * When true, the rope drives needs to be serviced and the ropes need to be tensioned.
                *
                */
   public bool tension_ropes;


   public void Set(JointStatus other)
   {
      halodi_msgs.msg.JointNamePubSubType.Copy(other.joint, joint);

      status_level = other.status_level;

      critical_for_balance = other.critical_for_balance;

      output_encoder_fault = other.output_encoder_fault;

      tension_ropes = other.tension_ropes;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("JointStatus {");
      builder.Append("joint=");
      builder.Append(this.joint);      builder.Append(", ");
      builder.Append("status_level=");
      builder.Append(this.status_level);      builder.Append(", ");
      builder.Append("critical_for_balance=");
      builder.Append(this.critical_for_balance);      builder.Append(", ");
      builder.Append("output_encoder_fault=");
      builder.Append(this.output_encoder_fault);      builder.Append(", ");
      builder.Append("tension_ropes=");
      builder.Append(this.tension_ropes);
      builder.Append("}");
      return builder.ToString();
   }
}


}