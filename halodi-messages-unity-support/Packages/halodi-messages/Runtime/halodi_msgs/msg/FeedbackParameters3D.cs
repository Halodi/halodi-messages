using System.Text;
namespace halodi_msgs.msg
{


/**
         *
         * Feedback gains for a 3 dimensional system.
         *
         */
[System.Serializable]
public class FeedbackParameters3D : Halodi.CDR.DataType<FeedbackParameters3D>
{

	public Halodi.CDR.TopicDataType<FeedbackParameters3D> Type => new FeedbackParameters3DPubSubType();
	
   /**
                * Proportional gains (Kp, stiffness)
                */
   public geometry_msgs.msg.Vector3 proportional;
   /**
                * Integral gains (Ki)
                *
                * NOTE: Not all controllers enable integrators
                * 
                * Optional.
                */
   public System.Collections.Generic.List<geometry_msgs.msg.Vector3> integral;
   /**
                * Derivative gains (Kd, damping)
                */
   public geometry_msgs.msg.Vector3 derivative;
   /**
                * Maximum proportional error used for feedback control. 
                * 
                * The absolute proportional error is clamped to this value.
                * 
                * Optional
                */
   public System.Collections.Generic.List<double> maximum_proportional_error;
   /**
                * Maximum integral windup
                * 
                * The absolute integral windup is clamped to this value
                * 
                * Optional
                */
   public System.Collections.Generic.List<double> maximum_integral_windup;
   /**
                * Maximum derivative error used for feedback control. 
                * 
                * The absolute derivative error is clamped to this value.
                * 
                * Optional
                */
   public System.Collections.Generic.List<double> maximum_derivative_error;
   /**
                * Maximum feedback.
                * 
                * The absolute value of the output of this feedback controller is clamped to this value
                * 
                * Optional
                */
   public System.Collections.Generic.List<double> maximum_feedback;
   /**
                * Maximum feedback rate.
                * 
                * The absolute value of the derivative of the output of this feedback controller is clamped to this value
                * 
                * Optional
                */
   public System.Collections.Generic.List<double> maximum_feedback_rate;
   /**
                * Integral leakage 
                * 
                * Reduces the integral term by this value per second
                * 
                * NOTE: This functionality is currently not implemented by the controller
                *
                * Optional
                */
   public System.Collections.Generic.List<double> integral_leakage;


   public void Set(FeedbackParameters3D other)
   {
      geometry_msgs.msg.Vector3PubSubType.Copy(other.proportional, proportional);


      if(other.integral == null)
      {
      	integral = null;
      }
      else
      {
      	integral = new System.Collections.Generic.List<geometry_msgs.msg.Vector3>(other.integral.Count);
      	for(int i1 = 0; i1 < other.integral.Count; i1++)
      	{
      		if(other.integral[i1] == null)
      		{
      			integral.Add(null);
      		}
      		else
      		{
      			geometry_msgs.msg.Vector3 newElement = geometry_msgs.msg.Vector3PubSubType.Create();
      	   		geometry_msgs.msg.Vector3PubSubType.Copy(other.integral[i1], newElement);
      	   		integral.Add(newElement);
      		}	}
      }
      geometry_msgs.msg.Vector3PubSubType.Copy(other.derivative, derivative);


      if(other.maximum_proportional_error == null)
      {
      	maximum_proportional_error = null;
      }
      else
      {
      	maximum_proportional_error = new System.Collections.Generic.List<double>(other.maximum_proportional_error.Count);
      	for(int i2 = 0; i2 < other.maximum_proportional_error.Count; i2++)
      	{
         		maximum_proportional_error.Add(other.maximum_proportional_error[i2]);
      	}
      }

      if(other.maximum_integral_windup == null)
      {
      	maximum_integral_windup = null;
      }
      else
      {
      	maximum_integral_windup = new System.Collections.Generic.List<double>(other.maximum_integral_windup.Count);
      	for(int i3 = 0; i3 < other.maximum_integral_windup.Count; i3++)
      	{
         		maximum_integral_windup.Add(other.maximum_integral_windup[i3]);
      	}
      }

      if(other.maximum_derivative_error == null)
      {
      	maximum_derivative_error = null;
      }
      else
      {
      	maximum_derivative_error = new System.Collections.Generic.List<double>(other.maximum_derivative_error.Count);
      	for(int i4 = 0; i4 < other.maximum_derivative_error.Count; i4++)
      	{
         		maximum_derivative_error.Add(other.maximum_derivative_error[i4]);
      	}
      }

      if(other.maximum_feedback == null)
      {
      	maximum_feedback = null;
      }
      else
      {
      	maximum_feedback = new System.Collections.Generic.List<double>(other.maximum_feedback.Count);
      	for(int i5 = 0; i5 < other.maximum_feedback.Count; i5++)
      	{
         		maximum_feedback.Add(other.maximum_feedback[i5]);
      	}
      }

      if(other.maximum_feedback_rate == null)
      {
      	maximum_feedback_rate = null;
      }
      else
      {
      	maximum_feedback_rate = new System.Collections.Generic.List<double>(other.maximum_feedback_rate.Count);
      	for(int i6 = 0; i6 < other.maximum_feedback_rate.Count; i6++)
      	{
         		maximum_feedback_rate.Add(other.maximum_feedback_rate[i6]);
      	}
      }

      if(other.integral_leakage == null)
      {
      	integral_leakage = null;
      }
      else
      {
      	integral_leakage = new System.Collections.Generic.List<double>(other.integral_leakage.Count);
      	for(int i7 = 0; i7 < other.integral_leakage.Count; i7++)
      	{
         		integral_leakage.Add(other.integral_leakage[i7]);
      	}
      }
   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("FeedbackParameters3D {");
      builder.Append("proportional=");
      builder.Append(this.proportional);      builder.Append(", ");
      builder.Append("integral=");
      builder.Append(this.integral);      builder.Append(", ");
      builder.Append("derivative=");
      builder.Append(this.derivative);      builder.Append(", ");
      builder.Append("maximum_proportional_error=");
      builder.Append(this.maximum_proportional_error);      builder.Append(", ");
      builder.Append("maximum_integral_windup=");
      builder.Append(this.maximum_integral_windup);      builder.Append(", ");
      builder.Append("maximum_derivative_error=");
      builder.Append(this.maximum_derivative_error);      builder.Append(", ");
      builder.Append("maximum_feedback=");
      builder.Append(this.maximum_feedback);      builder.Append(", ");
      builder.Append("maximum_feedback_rate=");
      builder.Append(this.maximum_feedback_rate);      builder.Append(", ");
      builder.Append("integral_leakage=");
      builder.Append(this.integral_leakage);
      builder.Append("}");
      return builder.ToString();
   }
}


}