using System.Text;
namespace halodi_msgs.msg
{


[System.Serializable]
public class TaskSpaceCommand : Halodi.CDR.DataType<TaskSpaceCommand>
{

	public Halodi.CDR.TopicDataType<TaskSpaceCommand> Type => new TaskSpaceCommandPubSubType();
	
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
                * Offset from the root of the body_frame to the controlled point.
                * 
                * Defaults to zero.
                *
                * This offset allows more accurate position control of a point on the hand or tool object, if the orientation of the wrist is not stiffly controlled.
                * 
                * Note: This offset does not get interpolated in the trajectory manager. 
                * If the frame_offset changes, the trajectory manager will reset the previous desired pose to the actual pose and interpolate from there. 
                * It is recommended to keep frame_offset constant during a task to avoid jumps in setpoints.
                *
                */
   public geometry_msgs.msg.Vector3 frame_offset;
   /**
                * 
                * Desired pose of the body frame + frame_offset, expressed in "expressed_in_frame"
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
                * (Optional) Input for the passivity layer. Internal use, keep disabled.
                *
                * If not set, the passivity layer will be disabled.
                *
                */
   public System.Collections.Generic.List<halodi_msgs.msg.PassivityData> passivity_input;
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
                *
                *
                * Motor damping applied to all joints in the chain to the root body of this body frame
                *
                * Optional. Defaults to 1
                *
                */
   public System.Collections.Generic.List<double> motor_damping;
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

      geometry_msgs.msg.Vector3PubSubType.Copy(other.frame_offset, frame_offset);

      geometry_msgs.msg.PosePubSubType.Copy(other.pose, pose);

      geometry_msgs.msg.Vector3PubSubType.Copy(other.angular_velocity, angular_velocity);

      geometry_msgs.msg.Vector3PubSubType.Copy(other.linear_velocity, linear_velocity);

      geometry_msgs.msg.Vector3PubSubType.Copy(other.angular_acceleration, angular_acceleration);

      geometry_msgs.msg.Vector3PubSubType.Copy(other.linear_acceleration, linear_acceleration);


      if(other.passivity_input == null)
      {
      	passivity_input = null;
      }
      else
      {
      	passivity_input = new System.Collections.Generic.List<halodi_msgs.msg.PassivityData>(other.passivity_input.Count);
      	for(int i1 = 0; i1 < other.passivity_input.Count; i1++)
      	{
      		if(other.passivity_input[i1] == null)
      		{
      			passivity_input.Add(null);
      		}
      		else
      		{
      			halodi_msgs.msg.PassivityData newElement = halodi_msgs.msg.PassivityDataPubSubType.Create();
      	   		halodi_msgs.msg.PassivityDataPubSubType.Copy(other.passivity_input[i1], newElement);
      	   		passivity_input.Add(newElement);
      		}	}
      }

      if(other.orientation_feedback_parameters == null)
      {
      	orientation_feedback_parameters = null;
      }
      else
      {
      	orientation_feedback_parameters = new System.Collections.Generic.List<halodi_msgs.msg.FeedbackParameters3D>(other.orientation_feedback_parameters.Count);
      	for(int i2 = 0; i2 < other.orientation_feedback_parameters.Count; i2++)
      	{
      		if(other.orientation_feedback_parameters[i2] == null)
      		{
      			orientation_feedback_parameters.Add(null);
      		}
      		else
      		{
      			halodi_msgs.msg.FeedbackParameters3D newElement = halodi_msgs.msg.FeedbackParameters3DPubSubType.Create();
      	   		halodi_msgs.msg.FeedbackParameters3DPubSubType.Copy(other.orientation_feedback_parameters[i2], newElement);
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
      	for(int i3 = 0; i3 < other.position_feedback_parameters.Count; i3++)
      	{
      		if(other.position_feedback_parameters[i3] == null)
      		{
      			position_feedback_parameters.Add(null);
      		}
      		else
      		{
      			halodi_msgs.msg.FeedbackParameters3D newElement = halodi_msgs.msg.FeedbackParameters3DPubSubType.Create();
      	   		halodi_msgs.msg.FeedbackParameters3DPubSubType.Copy(other.position_feedback_parameters[i3], newElement);
      	   		position_feedback_parameters.Add(newElement);
      		}	}
      }

      if(other.motor_damping == null)
      {
      	motor_damping = null;
      }
      else
      {
      	motor_damping = new System.Collections.Generic.List<double>(other.motor_damping.Count);
      	for(int i4 = 0; i4 < other.motor_damping.Count; i4++)
      	{
         		motor_damping.Add(other.motor_damping[i4]);
      	}
      }

      if(other.nullspace_command == null)
      {
      	nullspace_command = null;
      }
      else
      {
      	nullspace_command = new System.Collections.Generic.List<halodi_msgs.msg.JointNullSpaceConfiguration>(other.nullspace_command.Count);
      	for(int i5 = 0; i5 < other.nullspace_command.Count; i5++)
      	{
      		if(other.nullspace_command[i5] == null)
      		{
      			nullspace_command.Add(null);
      		}
      		else
      		{
      			halodi_msgs.msg.JointNullSpaceConfiguration newElement = halodi_msgs.msg.JointNullSpaceConfigurationPubSubType.Create();
      	   		halodi_msgs.msg.JointNullSpaceConfigurationPubSubType.Copy(other.nullspace_command[i5], newElement);
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
      builder.Append("frame_offset=");
      builder.Append(this.frame_offset);      builder.Append(", ");
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
      builder.Append("passivity_input=");
      builder.Append(this.passivity_input);      builder.Append(", ");
      builder.Append("orientation_feedback_parameters=");
      builder.Append(this.orientation_feedback_parameters);      builder.Append(", ");
      builder.Append("position_feedback_parameters=");
      builder.Append(this.position_feedback_parameters);      builder.Append(", ");
      builder.Append("motor_damping=");
      builder.Append(this.motor_damping);      builder.Append(", ");
      builder.Append("nullspace_command=");
      builder.Append(this.nullspace_command);
      builder.Append("}");
      return builder.ToString();
   }
}


}