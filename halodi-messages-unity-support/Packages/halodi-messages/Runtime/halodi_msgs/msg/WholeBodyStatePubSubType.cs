using System.IO;
namespace halodi_msgs.msg
{

/**
* 
* Topic data type of the struct "WholeBodyState" defined in "WholeBodyState.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from WholeBodyState.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit WholeBodyState.idl instead.
*
*/
public class WholeBodyStatePubSubType : Halodi.CDR.TopicDataType<WholeBodyState>
{
   public override string Name => "halodi_msgs::msg::dds_::WholeBodyState_";


   
   public override void serialize(halodi_msgs.msg.WholeBodyState data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, halodi_msgs.msg.WholeBodyState data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(halodi_msgs.msg.WholeBodyState data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(halodi_msgs.msg.WholeBodyState data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += std_msgs.msg.HeaderPubSubType.getCdrSerializedSize(data.header, current_alignment);

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.controller_state.Length + 1;

      current_alignment += halodi_msgs.msg.BalanceModePubSubType.getCdrSerializedSize(data.current_balance_mode, current_alignment);

      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);


      current_alignment += geometry_msgs.msg.PosePubSubType.getCdrSerializedSize(data.pose, current_alignment);

      current_alignment += geometry_msgs.msg.Vector3PubSubType.getCdrSerializedSize(data.angular_velocity, current_alignment);

      current_alignment += geometry_msgs.msg.Vector3PubSubType.getCdrSerializedSize(data.linear_velocity, current_alignment);

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.imu_measurements.Count; ++i0)
      {
          current_alignment += halodi_msgs.msg.ImuMeasurementPubSubType.getCdrSerializedSize(data.imu_measurements[i0], current_alignment);}

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.joint_states.Count; ++i0)
      {
          current_alignment += halodi_msgs.msg.JointMeasurementPubSubType.getCdrSerializedSize(data.joint_states[i0], current_alignment);}

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.taskspace_feedback.Count; ++i0)
      {
          current_alignment += halodi_msgs.msg.TaskSpaceFeedbackPubSubType.getCdrSerializedSize(data.taskspace_feedback[i0], current_alignment);}


      return current_alignment - initial_alignment;
   }

   public static void write(halodi_msgs.msg.WholeBodyState data, Halodi.CDR.CDRSerializer cdr)
   {
      std_msgs.msg.HeaderPubSubType.write(data.header, cdr);

      cdr.write_type_2(data.last_received_sequence_id);

      cdr.write_type_d(data.controller_state);

      halodi_msgs.msg.BalanceModePubSubType.write(data.current_balance_mode, cdr);

      cdr.write_type_9(data.robot_status);

      geometry_msgs.msg.PosePubSubType.write(data.pose, cdr);

      geometry_msgs.msg.Vector3PubSubType.write(data.angular_velocity, cdr);

      geometry_msgs.msg.Vector3PubSubType.write(data.linear_velocity, cdr);

      	if(data.imu_measurements == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int imu_measurements_length = data.imu_measurements.Count;
            cdr.write_type_2(imu_measurements_length);
            for (int i0 = 0; i0 < imu_measurements_length; i0++)
            {
      			halodi_msgs.msg.ImuMeasurementPubSubType.write(data.imu_measurements[i0], cdr);	      }
        }
      	if(data.joint_states == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int joint_states_length = data.joint_states.Count;
            cdr.write_type_2(joint_states_length);
            for (int i0 = 0; i0 < joint_states_length; i0++)
            {
      			halodi_msgs.msg.JointMeasurementPubSubType.write(data.joint_states[i0], cdr);	      }
        }
      	if(data.taskspace_feedback == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int taskspace_feedback_length = data.taskspace_feedback.Count;
            cdr.write_type_2(taskspace_feedback_length);
            for (int i0 = 0; i0 < taskspace_feedback_length; i0++)
            {
      			halodi_msgs.msg.TaskSpaceFeedbackPubSubType.write(data.taskspace_feedback[i0], cdr);	      }
        }
   }

   public static void read(halodi_msgs.msg.WholeBodyState data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.header = std_msgs.msg.HeaderPubSubType.Create();
      std_msgs.msg.HeaderPubSubType.read(data.header, cdr);
      	
      data.last_received_sequence_id=cdr.read_type_2();
      	
      data.controller_state = cdr.read_type_d();	
      data.current_balance_mode = halodi_msgs.msg.BalanceModePubSubType.Create();
      halodi_msgs.msg.BalanceModePubSubType.read(data.current_balance_mode, cdr);
      	
      data.robot_status=cdr.read_type_9();
      	
      data.pose = geometry_msgs.msg.PosePubSubType.Create();
      geometry_msgs.msg.PosePubSubType.read(data.pose, cdr);
      	
      data.angular_velocity = geometry_msgs.msg.Vector3PubSubType.Create();
      geometry_msgs.msg.Vector3PubSubType.read(data.angular_velocity, cdr);
      	
      data.linear_velocity = geometry_msgs.msg.Vector3PubSubType.Create();
      geometry_msgs.msg.Vector3PubSubType.read(data.linear_velocity, cdr);
      	

      int imu_measurements_length = cdr.read_type_2();
      data.imu_measurements = new System.Collections.Generic.List<halodi_msgs.msg.ImuMeasurement>(imu_measurements_length);
      for(int i = 0; i < imu_measurements_length; i++)
      {
      	halodi_msgs.msg.ImuMeasurement new_imu_measurements = halodi_msgs.msg.ImuMeasurementPubSubType.Create(); 
      	halodi_msgs.msg.ImuMeasurementPubSubType.read(new_imu_measurements, cdr);
      	data.imu_measurements.Add(new_imu_measurements);	
      	
      }

      	

      int joint_states_length = cdr.read_type_2();
      data.joint_states = new System.Collections.Generic.List<halodi_msgs.msg.JointMeasurement>(joint_states_length);
      for(int i = 0; i < joint_states_length; i++)
      {
      	halodi_msgs.msg.JointMeasurement new_joint_states = halodi_msgs.msg.JointMeasurementPubSubType.Create(); 
      	halodi_msgs.msg.JointMeasurementPubSubType.read(new_joint_states, cdr);
      	data.joint_states.Add(new_joint_states);	
      	
      }

      	

      int taskspace_feedback_length = cdr.read_type_2();
      data.taskspace_feedback = new System.Collections.Generic.List<halodi_msgs.msg.TaskSpaceFeedback>(taskspace_feedback_length);
      for(int i = 0; i < taskspace_feedback_length; i++)
      {
      	halodi_msgs.msg.TaskSpaceFeedback new_taskspace_feedback = halodi_msgs.msg.TaskSpaceFeedbackPubSubType.Create(); 
      	halodi_msgs.msg.TaskSpaceFeedbackPubSubType.read(new_taskspace_feedback, cdr);
      	data.taskspace_feedback.Add(new_taskspace_feedback);	
      	
      }

      	

   }


    public static void Copy(halodi_msgs.msg.WholeBodyState src, halodi_msgs.msg.WholeBodyState target)
    {
        target.Set(src);
    }


}


}