using System.Text;
namespace halodi_msgs.msg
{


/**
          * Full state of the robot
          *
          */
[System.Serializable]
public class WholeBodyState : Halodi.CDR.DataType<WholeBodyState>
{

	public Halodi.CDR.TopicDataType<WholeBodyState> Type => new WholeBodyStatePubSubType();
	
   /**
                 * Header including the timestamp of the robot when this measurement was taken
                 *
                 */
   public std_msgs.msg.Header header;
   /**
                 * Last received sequence_id from WholeBodyControllerCommand
                 *
                 */
   public int last_received_sequence_id;
   /**
                 * State of the control input module of the controller
                 *
                 * If this is not ACCEPTING_COMMANDS, commands from the API will get ignored. 
                 * 
                 */
   public halodi_msgs.msg.ControlInputState control_input_state;
   /**
                 * The current state of the balance module
                 */
   public string controller_state;
   /**
                 * The current balance mode the controller is using
                 */
   public halodi_msgs.msg.BalanceMode current_balance_mode;
   /**
                 * The status of the robot. Valid values are
                 * 
                 * diagnostic_msgs::msg:DiagnosticStatus::OK       (0)
                 * diagnostic_msgs::msg:DiagnosticStatus::WARN     (1)
                 * diagnostic_msgs::msg:DiagnosticStatus::ERROR    (2)
                 * diagnostic_msgs::msg:DiagnosticStatus::STALE    (3)
                 * 
                 */
   public byte robot_status;
   /**
                 * Pose of the root joint (pelvis) of the robot expressed in odometry frame
                 *
                 */
   public geometry_msgs.msg.Pose pose;
   /**
                 * Angular velocity of the root joint (pelvis) of the robot expressed in odometry frame
                 * 
                 */
   public geometry_msgs.msg.Vector3 angular_velocity;
   /**
                 * Linear velocity of the root joint (pelvis) of the robot expressed in odometry frame
                 * 
                 */
   public geometry_msgs.msg.Vector3 linear_velocity;
   /**
                * Pose of the robot expressed in the map frame
                *
                * This pose is calculated from data send to /eve/estimated_pose
                *
                */
   public geometry_msgs.msg.Pose map_pose;
   /**
                 * Raw IMU Measurements for each IMU on the robot
                 *
                 */
   public System.Collections.Generic.List<halodi_msgs.msg.ImuMeasurement> imu_measurements;
   /**
                 * State of each joint on the robot
                 *
                 */
   public System.Collections.Generic.List<halodi_msgs.msg.JointMeasurement> joint_states;
   /**
                * Output of the task space controllers. 
                * 
                * Useful for force feedback applications.
                *
                */
   public System.Collections.Generic.List<halodi_msgs.msg.TaskSpaceFeedback> taskspace_feedback;


   public void Set(WholeBodyState other)
   {
      std_msgs.msg.HeaderPubSubType.Copy(other.header, header);

      last_received_sequence_id = other.last_received_sequence_id;

      halodi_msgs.msg.ControlInputStatePubSubType.Copy(other.control_input_state, control_input_state);

      controller_state = other.controller_state;

      halodi_msgs.msg.BalanceModePubSubType.Copy(other.current_balance_mode, current_balance_mode);

      robot_status = other.robot_status;

      geometry_msgs.msg.PosePubSubType.Copy(other.pose, pose);

      geometry_msgs.msg.Vector3PubSubType.Copy(other.angular_velocity, angular_velocity);

      geometry_msgs.msg.Vector3PubSubType.Copy(other.linear_velocity, linear_velocity);

      geometry_msgs.msg.PosePubSubType.Copy(other.map_pose, map_pose);


      if(other.imu_measurements == null)
      {
      	imu_measurements = null;
      }
      else
      {
      	imu_measurements = new System.Collections.Generic.List<halodi_msgs.msg.ImuMeasurement>(other.imu_measurements.Count);
      	for(int i1 = 0; i1 < other.imu_measurements.Count; i1++)
      	{
      		if(other.imu_measurements[i1] == null)
      		{
      			imu_measurements.Add(null);
      		}
      		else
      		{
      			halodi_msgs.msg.ImuMeasurement newElement = halodi_msgs.msg.ImuMeasurementPubSubType.Create();
      	   		halodi_msgs.msg.ImuMeasurementPubSubType.Copy(other.imu_measurements[i1], newElement);
      	   		imu_measurements.Add(newElement);
      		}	}
      }

      if(other.joint_states == null)
      {
      	joint_states = null;
      }
      else
      {
      	joint_states = new System.Collections.Generic.List<halodi_msgs.msg.JointMeasurement>(other.joint_states.Count);
      	for(int i2 = 0; i2 < other.joint_states.Count; i2++)
      	{
      		if(other.joint_states[i2] == null)
      		{
      			joint_states.Add(null);
      		}
      		else
      		{
      			halodi_msgs.msg.JointMeasurement newElement = halodi_msgs.msg.JointMeasurementPubSubType.Create();
      	   		halodi_msgs.msg.JointMeasurementPubSubType.Copy(other.joint_states[i2], newElement);
      	   		joint_states.Add(newElement);
      		}	}
      }

      if(other.taskspace_feedback == null)
      {
      	taskspace_feedback = null;
      }
      else
      {
      	taskspace_feedback = new System.Collections.Generic.List<halodi_msgs.msg.TaskSpaceFeedback>(other.taskspace_feedback.Count);
      	for(int i3 = 0; i3 < other.taskspace_feedback.Count; i3++)
      	{
      		if(other.taskspace_feedback[i3] == null)
      		{
      			taskspace_feedback.Add(null);
      		}
      		else
      		{
      			halodi_msgs.msg.TaskSpaceFeedback newElement = halodi_msgs.msg.TaskSpaceFeedbackPubSubType.Create();
      	   		halodi_msgs.msg.TaskSpaceFeedbackPubSubType.Copy(other.taskspace_feedback[i3], newElement);
      	   		taskspace_feedback.Add(newElement);
      		}	}
      }
   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("WholeBodyState {");
      builder.Append("header=");
      builder.Append(this.header);      builder.Append(", ");
      builder.Append("last_received_sequence_id=");
      builder.Append(this.last_received_sequence_id);      builder.Append(", ");
      builder.Append("control_input_state=");
      builder.Append(this.control_input_state);      builder.Append(", ");
      builder.Append("controller_state=");
      builder.Append(this.controller_state);      builder.Append(", ");
      builder.Append("current_balance_mode=");
      builder.Append(this.current_balance_mode);      builder.Append(", ");
      builder.Append("robot_status=");
      builder.Append(this.robot_status);      builder.Append(", ");
      builder.Append("pose=");
      builder.Append(this.pose);      builder.Append(", ");
      builder.Append("angular_velocity=");
      builder.Append(this.angular_velocity);      builder.Append(", ");
      builder.Append("linear_velocity=");
      builder.Append(this.linear_velocity);      builder.Append(", ");
      builder.Append("map_pose=");
      builder.Append(this.map_pose);      builder.Append(", ");
      builder.Append("imu_measurements=");
      builder.Append(this.imu_measurements);      builder.Append(", ");
      builder.Append("joint_states=");
      builder.Append(this.joint_states);      builder.Append(", ");
      builder.Append("taskspace_feedback=");
      builder.Append(this.taskspace_feedback);
      builder.Append("}");
      return builder.ToString();
   }
}


}