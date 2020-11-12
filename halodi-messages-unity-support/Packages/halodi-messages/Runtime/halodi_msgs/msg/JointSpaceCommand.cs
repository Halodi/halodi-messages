using System.Text;
namespace halodi_msgs.msg
{


/**
         *
         * Joint space command for the whole body controller
         *
         */
[System.Serializable]
public class JointSpaceCommand
{
   public halodi_msgs.msg.JointName joint;
   /**
                * Desired joint angle
                * 
                * Unit: rad
                *
                */
   public double q_desired;
   /**
                * Desired joint velocity
                * 
                * Unit: rad/s
                *
                */
   public double qd_desired;
   /**
                * Desired feedforward joint acceleration
                * 
                * Unit: rad/s^2
                *
                */
   public double qdd_desired;
   /**
                * (Optional) Break frequency to filter q_desired.
                * 
                * Useful to smooth out noisy or jerky inputs (for example joystick/mouse). 
                *
                * Unit: Hz 
                *
                * Note: filtering is applied at the realtime controller, after any interpolation of the trajectory manager.
                *
                */
   public System.Collections.Generic.List<double> q_desired_filter_break_frequency;
   /**
                *
                * If set to true, qd_desired is calculated to be the derivative of q_desired.
                * 
                * It is recommeded to set q_desired_filter_break_frequency when using this to avoid large jumps in velocity.
                *
                */
   public bool derive_qd_desired;
   /**
                * Use sensible default gains as provided by the controller instead of custom gains.
                * 
                * Recommended to use for initial testing.
                */
   public bool use_default_gains;
   /**
                * Desired stiffness of the PD Controller for this joint. 
                * 
                * Unit: (rad/s^2)/rad
                * The output of this controller is joint acceleration.
                * Ignored when use_default_gains is set
                */
   public double stiffness;
   /**
                * Desired damping of the PD Controller for this joint.
                * 
                * Unit: (rad/s^2)/rad
                * The output of this controller is joint acceleration.
                * Ignored when use_default_gains is set
                */
   public double damping;
   /**
                * 
                * Desired damping (scale) applied on the motor driver level for this joint.
                * 
                * The amount of joint damping that can be applied without instability is limited. 
                * To increase the applied damping, damping can be applied at the motor driver level. 
                * 
                * The applied motor damping is: motorDampingScale * maximumMotorDamping * (q_desired(motor) - q_actual(motor))
                * - maximumMotorDamping is specific to each motor, and is set from factory. The applied damping does not neccessarly correlate with physical numbers.
                *  
                * motorDampingScale is a scale between 0 and 1 (inclusive). Set to 0 to disable motor damping.
                * 
                * When joints share motors (in the differential drives), the highest motor level damping is used on both motors.
                * 
                * 
                * Unit: [0.0 - 1.0]
                *
                *
                */
   public double motorDampingScale;
   /**
                * Maximum feedback appied on the joint.
                * 
                * This ignores feedback due to motorDampingScale
                * 
                * Unit: rad/s^2
                * Ignored when use_default_gains is set
                * 
                * When set to 0, no feedback will be applied. 
                * 
                */
   public double max_feedback;


   public void Set(JointSpaceCommand other)
   {
      halodi_msgs.msg.JointNamePubSubType.Copy(other.joint, joint);

      q_desired = other.q_desired;

      qd_desired = other.qd_desired;

      qdd_desired = other.qdd_desired;


      if(other.q_desired_filter_break_frequency == null)
      {
      	q_desired_filter_break_frequency = null;
      }
      else
      {
      	q_desired_filter_break_frequency = new System.Collections.Generic.List<double>(other.q_desired_filter_break_frequency.Count);
      	for(int i1 = 0; i1 < other.q_desired_filter_break_frequency.Count; i1++)
      	{
         		q_desired_filter_break_frequency.Add(other.q_desired_filter_break_frequency[i1]);
      	}
      }
      derive_qd_desired = other.derive_qd_desired;

      use_default_gains = other.use_default_gains;

      stiffness = other.stiffness;

      damping = other.damping;

      motorDampingScale = other.motorDampingScale;

      max_feedback = other.max_feedback;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("JointSpaceCommand {");
      builder.Append("joint=");
      builder.Append(this.joint);      builder.Append(", ");
      builder.Append("q_desired=");
      builder.Append(this.q_desired);      builder.Append(", ");
      builder.Append("qd_desired=");
      builder.Append(this.qd_desired);      builder.Append(", ");
      builder.Append("qdd_desired=");
      builder.Append(this.qdd_desired);      builder.Append(", ");
      builder.Append("q_desired_filter_break_frequency=");
      builder.Append(this.q_desired_filter_break_frequency);      builder.Append(", ");
      builder.Append("derive_qd_desired=");
      builder.Append(this.derive_qd_desired);      builder.Append(", ");
      builder.Append("use_default_gains=");
      builder.Append(this.use_default_gains);      builder.Append(", ");
      builder.Append("stiffness=");
      builder.Append(this.stiffness);      builder.Append(", ");
      builder.Append("damping=");
      builder.Append(this.damping);      builder.Append(", ");
      builder.Append("motorDampingScale=");
      builder.Append(this.motorDampingScale);      builder.Append(", ");
      builder.Append("max_feedback=");
      builder.Append(this.max_feedback);
      builder.Append("}");
      return builder.ToString();
   }
}


}