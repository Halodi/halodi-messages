using System.IO;
namespace halodi_msgs.msg
{

/**
* 
* Topic data type of the struct "TaskSpaceFeedback" defined in "TaskSpaceFeedback.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from TaskSpaceFeedback.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit TaskSpaceFeedback.idl instead.
*
*/
public class TaskSpaceFeedbackPubSubType : Halodi.CDR.TopicDataType<TaskSpaceFeedback>
{
   public override string Name => "halodi_msgs::msg::dds_::TaskSpaceFeedback_";


   
   public override void serialize(halodi_msgs.msg.TaskSpaceFeedback data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, halodi_msgs.msg.TaskSpaceFeedback data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(halodi_msgs.msg.TaskSpaceFeedback data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(halodi_msgs.msg.TaskSpaceFeedback data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += halodi_msgs.msg.ReferenceFrameNamePubSubType.getCdrSerializedSize(data.body_frame, current_alignment);

      current_alignment += halodi_msgs.msg.ReferenceFrameNamePubSubType.getCdrSerializedSize(data.expressed_in_frame, current_alignment);

      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);


      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);


      current_alignment += geometry_msgs.msg.Vector3PubSubType.getCdrSerializedSize(data.angular_effort, current_alignment);

      current_alignment += geometry_msgs.msg.Vector3PubSubType.getCdrSerializedSize(data.linear_effort, current_alignment);

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.energy_output.Count * 8) + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.energy_tank_level.Count * 8) + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);



      return current_alignment - initial_alignment;
   }

   public static void write(halodi_msgs.msg.TaskSpaceFeedback data, Halodi.CDR.CDRSerializer cdr)
   {
      halodi_msgs.msg.ReferenceFrameNamePubSubType.write(data.body_frame, cdr);

      halodi_msgs.msg.ReferenceFrameNamePubSubType.write(data.expressed_in_frame, cdr);

      cdr.write_type_7(data.express_in_z_up);

      cdr.write_type_7(data.using_force_feedback);

      geometry_msgs.msg.Vector3PubSubType.write(data.angular_effort, cdr);

      geometry_msgs.msg.Vector3PubSubType.write(data.linear_effort, cdr);

      	if(data.energy_output == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int energy_output_length = data.energy_output.Count;
            cdr.write_type_2(energy_output_length);
            for (int i0 = 0; i0 < energy_output_length; i0++)
            {
      			cdr.write_type_6(data.energy_output[i0]);
            }
        }
      	if(data.energy_tank_level == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int energy_tank_level_length = data.energy_tank_level.Count;
            cdr.write_type_2(energy_tank_level_length);
            for (int i0 = 0; i0 < energy_tank_level_length; i0++)
            {
      			cdr.write_type_6(data.energy_tank_level[i0]);
            }
        }
   }

   public static void read(halodi_msgs.msg.TaskSpaceFeedback data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.body_frame = halodi_msgs.msg.ReferenceFrameNamePubSubType.Create();
      halodi_msgs.msg.ReferenceFrameNamePubSubType.read(data.body_frame, cdr);
      	
      data.expressed_in_frame = halodi_msgs.msg.ReferenceFrameNamePubSubType.Create();
      halodi_msgs.msg.ReferenceFrameNamePubSubType.read(data.expressed_in_frame, cdr);
      	
      data.express_in_z_up=cdr.read_type_7();
      	
      data.using_force_feedback=cdr.read_type_7();
      	
      data.angular_effort = geometry_msgs.msg.Vector3PubSubType.Create();
      geometry_msgs.msg.Vector3PubSubType.read(data.angular_effort, cdr);
      	
      data.linear_effort = geometry_msgs.msg.Vector3PubSubType.Create();
      geometry_msgs.msg.Vector3PubSubType.read(data.linear_effort, cdr);
      	

      int energy_output_length = cdr.read_type_2();
      data.energy_output = new System.Collections.Generic.List<double>(energy_output_length);
      for(int i = 0; i < energy_output_length; i++)
      {
      	data.energy_output.Add(cdr.read_type_6());
      	
      	
      }

      	

      int energy_tank_level_length = cdr.read_type_2();
      data.energy_tank_level = new System.Collections.Generic.List<double>(energy_tank_level_length);
      for(int i = 0; i < energy_tank_level_length; i++)
      {
      	data.energy_tank_level.Add(cdr.read_type_6());
      	
      	
      }

      	

   }


    public static void Copy(halodi_msgs.msg.TaskSpaceFeedback src, halodi_msgs.msg.TaskSpaceFeedback target)
    {
        target.Set(src);
    }


}


}