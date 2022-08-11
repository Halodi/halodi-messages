using System.IO;
namespace ocs2_ros2_msgs.msg
{

/**
* 
* Topic data type of the struct "MpcFlattenedController" defined in "MpcFlattenedController.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from MpcFlattenedController.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit MpcFlattenedController.idl instead.
*
*/
public class MpcFlattenedControllerPubSubType : Halodi.CDR.TopicDataType<MpcFlattenedController>
{
   public override string Name => "ocs2_ros2_msgs::msg::dds_::MpcFlattenedController_";


   
   public override void serialize(ocs2_ros2_msgs.msg.MpcFlattenedController data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, ocs2_ros2_msgs.msg.MpcFlattenedController data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(ocs2_ros2_msgs.msg.MpcFlattenedController data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(ocs2_ros2_msgs.msg.MpcFlattenedController data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);


      current_alignment += ocs2_ros2_msgs.msg.MpcObservationPubSubType.getCdrSerializedSize(data.init_observation, current_alignment);

      current_alignment += ocs2_ros2_msgs.msg.MpcTargetTrajectoriesPubSubType.getCdrSerializedSize(data.plan_target_trajectories, current_alignment);

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.state_trajectory.Count; ++i0)
      {
          current_alignment += ocs2_ros2_msgs.msg.MpcStatePubSubType.getCdrSerializedSize(data.state_trajectory[i0], current_alignment);}

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.input_trajectory.Count; ++i0)
      {
          current_alignment += ocs2_ros2_msgs.msg.MpcInputPubSubType.getCdrSerializedSize(data.input_trajectory[i0], current_alignment);}

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.time_trajectory.Count * 4) + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.post_event_indices.Count * 1) + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);


      current_alignment += ocs2_ros2_msgs.msg.ModeSchedulePubSubType.getCdrSerializedSize(data.mode_schedule, current_alignment);

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.data.Count; ++i0)
      {
          current_alignment += ocs2_ros2_msgs.msg.ControllerDataPubSubType.getCdrSerializedSize(data.data[i0], current_alignment);}

      current_alignment += ocs2_ros2_msgs.msg.MpcPerformanceIndicesPubSubType.getCdrSerializedSize(data.performance_indices, current_alignment);


      return current_alignment - initial_alignment;
   }

   public static void write(ocs2_ros2_msgs.msg.MpcFlattenedController data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_2(data.api_version);

      cdr.write_type_9(data.controller_type);

      ocs2_ros2_msgs.msg.MpcObservationPubSubType.write(data.init_observation, cdr);

      ocs2_ros2_msgs.msg.MpcTargetTrajectoriesPubSubType.write(data.plan_target_trajectories, cdr);

      	if(data.state_trajectory == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int state_trajectory_length = data.state_trajectory.Count;
            cdr.write_type_2(state_trajectory_length);
            for (int i0 = 0; i0 < state_trajectory_length; i0++)
            {
      			ocs2_ros2_msgs.msg.MpcStatePubSubType.write(data.state_trajectory[i0], cdr);	      }
        }
      	if(data.input_trajectory == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int input_trajectory_length = data.input_trajectory.Count;
            cdr.write_type_2(input_trajectory_length);
            for (int i0 = 0; i0 < input_trajectory_length; i0++)
            {
      			ocs2_ros2_msgs.msg.MpcInputPubSubType.write(data.input_trajectory[i0], cdr);	      }
        }
      	if(data.time_trajectory == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int time_trajectory_length = data.time_trajectory.Count;
            cdr.write_type_2(time_trajectory_length);
            for (int i0 = 0; i0 < time_trajectory_length; i0++)
            {
      			cdr.write_type_5(data.time_trajectory[i0]);
            }
        }
      	if(data.post_event_indices == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int post_event_indices_length = data.post_event_indices.Count;
            cdr.write_type_2(post_event_indices_length);
            for (int i0 = 0; i0 < post_event_indices_length; i0++)
            {
      			cdr.write_type_9(data.post_event_indices[i0]);
            }
        }
      ocs2_ros2_msgs.msg.ModeSchedulePubSubType.write(data.mode_schedule, cdr);

      	if(data.data == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int data_length = data.data.Count;
            cdr.write_type_2(data_length);
            for (int i0 = 0; i0 < data_length; i0++)
            {
      			ocs2_ros2_msgs.msg.ControllerDataPubSubType.write(data.data[i0], cdr);	      }
        }
      ocs2_ros2_msgs.msg.MpcPerformanceIndicesPubSubType.write(data.performance_indices, cdr);

   }

   public static void read(ocs2_ros2_msgs.msg.MpcFlattenedController data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.api_version=cdr.read_type_2();
      	
      data.controller_type=cdr.read_type_9();
      	
      data.init_observation = ocs2_ros2_msgs.msg.MpcObservationPubSubType.Create();
      ocs2_ros2_msgs.msg.MpcObservationPubSubType.read(data.init_observation, cdr);
      	
      data.plan_target_trajectories = ocs2_ros2_msgs.msg.MpcTargetTrajectoriesPubSubType.Create();
      ocs2_ros2_msgs.msg.MpcTargetTrajectoriesPubSubType.read(data.plan_target_trajectories, cdr);
      	

      int state_trajectory_length = cdr.read_type_2();
      data.state_trajectory = new System.Collections.Generic.List<ocs2_ros2_msgs.msg.MpcState>(state_trajectory_length);
      for(int i = 0; i < state_trajectory_length; i++)
      {
      	ocs2_ros2_msgs.msg.MpcState new_state_trajectory = ocs2_ros2_msgs.msg.MpcStatePubSubType.Create(); 
      	ocs2_ros2_msgs.msg.MpcStatePubSubType.read(new_state_trajectory, cdr);
      	data.state_trajectory.Add(new_state_trajectory);	
      	
      }

      	

      int input_trajectory_length = cdr.read_type_2();
      data.input_trajectory = new System.Collections.Generic.List<ocs2_ros2_msgs.msg.MpcInput>(input_trajectory_length);
      for(int i = 0; i < input_trajectory_length; i++)
      {
      	ocs2_ros2_msgs.msg.MpcInput new_input_trajectory = ocs2_ros2_msgs.msg.MpcInputPubSubType.Create(); 
      	ocs2_ros2_msgs.msg.MpcInputPubSubType.read(new_input_trajectory, cdr);
      	data.input_trajectory.Add(new_input_trajectory);	
      	
      }

      	

      int time_trajectory_length = cdr.read_type_2();
      data.time_trajectory = new System.Collections.Generic.List<float>(time_trajectory_length);
      for(int i = 0; i < time_trajectory_length; i++)
      {
      	data.time_trajectory.Add(cdr.read_type_5());
      	
      	
      }

      	

      int post_event_indices_length = cdr.read_type_2();
      data.post_event_indices = new System.Collections.Generic.List<byte>(post_event_indices_length);
      for(int i = 0; i < post_event_indices_length; i++)
      {
      	data.post_event_indices.Add(cdr.read_type_9());
      	
      	
      }

      	
      data.mode_schedule = ocs2_ros2_msgs.msg.ModeSchedulePubSubType.Create();
      ocs2_ros2_msgs.msg.ModeSchedulePubSubType.read(data.mode_schedule, cdr);
      	

      int data_length = cdr.read_type_2();
      data.data = new System.Collections.Generic.List<ocs2_ros2_msgs.msg.ControllerData>(data_length);
      for(int i = 0; i < data_length; i++)
      {
      	ocs2_ros2_msgs.msg.ControllerData new_data = ocs2_ros2_msgs.msg.ControllerDataPubSubType.Create(); 
      	ocs2_ros2_msgs.msg.ControllerDataPubSubType.read(new_data, cdr);
      	data.data.Add(new_data);	
      	
      }

      	
      data.performance_indices = ocs2_ros2_msgs.msg.MpcPerformanceIndicesPubSubType.Create();
      ocs2_ros2_msgs.msg.MpcPerformanceIndicesPubSubType.read(data.performance_indices, cdr);
      	

   }


    public static void Copy(ocs2_ros2_msgs.msg.MpcFlattenedController src, ocs2_ros2_msgs.msg.MpcFlattenedController target)
    {
        target.Set(src);
    }


}


}