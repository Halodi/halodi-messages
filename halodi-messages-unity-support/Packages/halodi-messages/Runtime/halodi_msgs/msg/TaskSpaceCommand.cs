using System.Text;
namespace halodi_msgs.msg
{


[System.Serializable]
public class TaskSpaceCommand
{
   /**
                * Body Frame: The reference frame to control.
                *
                * Valid options are all frames that are "Controllable"
                *
                */
   public halodi_msgs.msg.ReferenceFrameName body_frame;
   /**
                * Expressed in frame: Origin of the command.
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
                * 
                * Desired pose of the body frame, expressed in "expressed_in_frame"
                *
                */
   public geometry_msgs.msg.Pose pose;
   /**
                * 
                * Desired angular velocity of the body frame, expressed in "expressed_in_frame"
                *
                */
   public geometry_msgs.msg.Vector3 angular_velocity;
   /**
                * 
                * Desired linear velocity of the body frame, expressed in "expressed_in_frame"
                *
                */
   public geometry_msgs.msg.Vector3 linear_velocity;
   /**
                * Desired angular acceleration of the body frame, expressed in "expressed_in_frame"
                *
                */
   public geometry_msgs.msg.Vector3 angular_acceleration;
   /**
                * Desired linear acceleration of the body frame, expressed in "expressed_in_frame"
                *
                */
   public geometry_msgs.msg.Vector3 linear_acceleration;
   /**
                *
                * Angular feedback parameters
                *
                * Optional. When not provided, default values are used
                *
                */
   public System.Collections.Generic.List<halodi_msgs.msg.FeedbackParameters3D> orientation_feedback_parameters;
   /**
                *
                * Linear feedback parameters
                *
                * Optional. When not provided, default values are used
                *
                */
   public System.Collections.Generic.List<halodi_msgs.msg.FeedbackParameters3D> position_feedback_parameters;
   /**
                * Nullspace joint configuration 
                *
                */
   public System.Collections.Generic.List<halodi_msgs.msg.JointNullSpaceConfiguration> nullspace_command;


   public void Set(TaskSpaceCommand other)
   {
      halodi_msgs.msg.ReferenceFrameNamePubSubType.Copy(other.body_frame, body_frame);

      halodi_msgs.msg.ReferenceFrameNamePubSubType.Copy(other.expressed_in_frame, expressed_in_frame);

      express_in_z_up = other.express_in_z_up;

      geometry_msgs.msg.PosePubSubType.Copy(other.pose, pose);

      geometry_msgs.msg.Vector3PubSubType.Copy(other.angular_velocity, angular_velocity);

      geometry_msgs.msg.Vector3PubSubType.Copy(other.linear_velocity, linear_velocity);

      geometry_msgs.msg.Vector3PubSubType.Copy(other.angular_acceleration, angular_acceleration);

      geometry_msgs.msg.Vector3PubSubType.Copy(other.linear_acceleration, linear_acceleration);


      if(other.orientation_feedback_parameters == null)
      {
      	orientation_feedback_parameters = null;
      }
      else
      {
      	orientation_feedback_parameters = new System.Collections.Generic.List<halodi_msgs.msg.FeedbackParameters3D>(other.orientation_feedback_parameters.Count);
      	for(int i1 = 0; i1 < other.orientation_feedback_parameters.Count; i1++)
      	{
      		if(other.orientation_feedback_parameters[i1] == null)
      		{
      			orientation_feedback_parameters.Add(null);
      		}
      		else
      		{
      			halodi_msgs.msg.FeedbackParameters3D newElement = halodi_msgs.msg.FeedbackParameters3DPubSubType.Create();
      	   		halodi_msgs.msg.FeedbackParameters3DPubSubType.Copy(other.orientation_feedback_parameters[i1], newElement);
      	   		orientation_feedback_parameters.Add(newElement);
      		}	}
      }

      if(other.position_feedback_parameters == null)
      {
      	position_feedback_parameters = null;
      }
      else
      {
      	position_feedback_parameters = new System.Collections.Generic.List<halodi_msgs.msg.FeedbackParameters3D>(other.position_feedback_parameters.Count);
      	for(int i2 = 0; i2 < other.position_feedback_parameters.Count; i2++)
      	{
      		if(other.position_feedback_parameters[i2] == null)
      		{
      			position_feedback_parameters.Add(null);
      		}
      		else
      		{
      			halodi_msgs.msg.FeedbackParameters3D newElement = halodi_msgs.msg.FeedbackParameters3DPubSubType.Create();
      	   		halodi_msgs.msg.FeedbackParameters3DPubSubType.Copy(other.position_feedback_parameters[i2], newElement);
      	   		position_feedback_parameters.Add(newElement);
      		}	}
      }

      if(other.nullspace_command == null)
      {
      	nullspace_command = null;
      }
      else
      {
      	nullspace_command = new System.Collections.Generic.List<halodi_msgs.msg.JointNullSpaceConfiguration>(other.nullspace_command.Count);
      	for(int i3 = 0; i3 < other.nullspace_command.Count; i3++)
      	{
      		if(other.nullspace_command[i3] == null)
      		{
      			nullspace_command.Add(null);
      		}
      		else
      		{
      			halodi_msgs.msg.JointNullSpaceConfiguration newElement = halodi_msgs.msg.JointNullSpaceConfigurationPubSubType.Create();
      	   		halodi_msgs.msg.JointNullSpaceConfigurationPubSubType.Copy(other.nullspace_command[i3], newElement);
      	   		nullspace_command.Add(newElement);
      		}	}
      }
   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("TaskSpaceCommand {");
      builder.Append("body_frame=");
      builder.Append(this.body_frame);      builder.Append(", ");
      builder.Append("expressed_in_frame=");
      builder.Append(this.expressed_in_frame);      builder.Append(", ");
      builder.Append("express_in_z_up=");
      builder.Append(this.express_in_z_up);      builder.Append(", ");
      builder.Append("pose=");
      builder.Append(this.pose);      builder.Append(", ");
      builder.Append("angular_velocity=");
      builder.Append(this.angular_velocity);      builder.Append(", ");
      builder.Append("linear_velocity=");
      builder.Append(this.linear_velocity);      builder.Append(", ");
      builder.Append("angular_acceleration=");
      builder.Append(this.angular_acceleration);      builder.Append(", ");
      builder.Append("linear_acceleration=");
      builder.Append(this.linear_acceleration);      builder.Append(", ");
      builder.Append("orientation_feedback_parameters=");
      builder.Append(this.orientation_feedback_parameters);      builder.Append(", ");
      builder.Append("position_feedback_parameters=");
      builder.Append(this.position_feedback_parameters);      builder.Append(", ");
      builder.Append("nullspace_command=");
      builder.Append(this.nullspace_command);
      builder.Append("}");
      return builder.ToString();
   }
}


}