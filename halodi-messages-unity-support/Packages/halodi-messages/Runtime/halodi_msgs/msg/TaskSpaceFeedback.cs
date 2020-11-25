using System.Text;
namespace halodi_msgs.msg
{


[System.Serializable]
public class TaskSpaceFeedback : Halodi.CDR.DataType<TaskSpaceFeedback>
{

	public Halodi.CDR.TopicDataType<TaskSpaceFeedback> Type => new TaskSpaceFeedbackPubSubType();
	
   /**
                * Body Frame: The reference frame that is being controlled.
                *
                * Valid options are all frames that are "Controllable"
                *
                */
   public halodi_msgs.msg.ReferenceFrameName body_frame;
   /**
                * Expressed in frame: Origin of the feedback.
                *
                * Valid options are all frames that are "Expressable in"
                *
                */
   public halodi_msgs.msg.ReferenceFrameName expressed_in_frame;
   /**
                * Align the orientation of the expressed in frame such that z-axis points up. 
                * 
                * The heading (also known as yaw or the rotation around the z-axis) and position match the expressed_in_frame.
                *
                * This can be useful for keeping an end effector aligned with gravity while moving.
                * 
                */
   public bool express_in_z_up;
   /**
                * Desired angular acceleration (rad/s^2) applied on the body frame, expressed in "expressed_in_frame"
                *
                * Note: This is the desired from the angular acceleration PD controller, not achieved from the QP.
                *
                */
   public geometry_msgs.msg.Vector3 angular_acceleration;
   /**
                * Desired linear acceleration (rad/s^2) applied on the body frame, expressed in "expressed_in_frame"
                *
                * Note: This is the desired from the linear acceleration PD controller, not achieved from the QP.
                *
                */
   public geometry_msgs.msg.Vector3 linear_acceleration;
   /**
                * (Optional) Output of the passivity layer. Internal use, keep disabled.
                *
                * If not set, the passivity layer will be disabled.
                *
                */
   public System.Collections.Generic.List<halodi_msgs.msg.PassivityData> passivity_output;


   public void Set(TaskSpaceFeedback other)
   {
      halodi_msgs.msg.ReferenceFrameNamePubSubType.Copy(other.body_frame, body_frame);

      halodi_msgs.msg.ReferenceFrameNamePubSubType.Copy(other.expressed_in_frame, expressed_in_frame);

      express_in_z_up = other.express_in_z_up;

      geometry_msgs.msg.Vector3PubSubType.Copy(other.angular_acceleration, angular_acceleration);

      geometry_msgs.msg.Vector3PubSubType.Copy(other.linear_acceleration, linear_acceleration);


      if(other.passivity_output == null)
      {
      	passivity_output = null;
      }
      else
      {
      	passivity_output = new System.Collections.Generic.List<halodi_msgs.msg.PassivityData>(other.passivity_output.Count);
      	for(int i1 = 0; i1 < other.passivity_output.Count; i1++)
      	{
      		if(other.passivity_output[i1] == null)
      		{
      			passivity_output.Add(null);
      		}
      		else
      		{
      			halodi_msgs.msg.PassivityData newElement = halodi_msgs.msg.PassivityDataPubSubType.Create();
      	   		halodi_msgs.msg.PassivityDataPubSubType.Copy(other.passivity_output[i1], newElement);
      	   		passivity_output.Add(newElement);
      		}	}
      }
   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("TaskSpaceFeedback {");
      builder.Append("body_frame=");
      builder.Append(this.body_frame);      builder.Append(", ");
      builder.Append("expressed_in_frame=");
      builder.Append(this.expressed_in_frame);      builder.Append(", ");
      builder.Append("express_in_z_up=");
      builder.Append(this.express_in_z_up);      builder.Append(", ");
      builder.Append("angular_acceleration=");
      builder.Append(this.angular_acceleration);      builder.Append(", ");
      builder.Append("linear_acceleration=");
      builder.Append(this.linear_acceleration);      builder.Append(", ");
      builder.Append("passivity_output=");
      builder.Append(this.passivity_output);
      builder.Append("}");
      return builder.ToString();
   }
}


}