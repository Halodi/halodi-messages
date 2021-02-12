using System.IO;
namespace ocs2_ros2_msgs.msg
{

/**
* 
* Topic data type of the struct "ModeSchedule" defined in "ModeSchedule.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from ModeSchedule.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit ModeSchedule.idl instead.
*
*/
public class ModeSchedulePubSubType : Halodi.CDR.TopicDataType<ModeSchedule>
{
   public override string Name => "ocs2_ros2_msgs::msg::dds_::ModeSchedule_";


   
   public override void serialize(ocs2_ros2_msgs.msg.ModeSchedule data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, ocs2_ros2_msgs.msg.ModeSchedule data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(ocs2_ros2_msgs.msg.ModeSchedule data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(ocs2_ros2_msgs.msg.ModeSchedule data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.event_times.Count * 4) + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.mode_sequence.Count * 1) + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);



      return current_alignment - initial_alignment;
   }

   public static void write(ocs2_ros2_msgs.msg.ModeSchedule data, Halodi.CDR.CDRSerializer cdr)
   {
      	if(data.event_times == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int event_times_length = data.event_times.Count;
            cdr.write_type_2(event_times_length);
            for (int i0 = 0; i0 < event_times_length; i0++)
            {
      			cdr.write_type_5(data.event_times[i0]);
            }
        }
      	if(data.mode_sequence == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int mode_sequence_length = data.mode_sequence.Count;
            cdr.write_type_2(mode_sequence_length);
            for (int i0 = 0; i0 < mode_sequence_length; i0++)
            {
      			cdr.write_type_9(data.mode_sequence[i0]);
            }
        }
   }

   public static void read(ocs2_ros2_msgs.msg.ModeSchedule data, Halodi.CDR.CDRDeserializer cdr)
   {

      int event_times_length = cdr.read_type_2();
      data.event_times = new System.Collections.Generic.List<float>(event_times_length);
      for(int i = 0; i < event_times_length; i++)
      {
      	data.event_times.Add(cdr.read_type_5());
      	
      	
      }

      	

      int mode_sequence_length = cdr.read_type_2();
      data.mode_sequence = new System.Collections.Generic.List<byte>(mode_sequence_length);
      for(int i = 0; i < mode_sequence_length; i++)
      {
      	data.mode_sequence.Add(cdr.read_type_9());
      	
      	
      }

      	

   }


    public static void Copy(ocs2_ros2_msgs.msg.ModeSchedule src, ocs2_ros2_msgs.msg.ModeSchedule target)
    {
        target.Set(src);
    }


}


}