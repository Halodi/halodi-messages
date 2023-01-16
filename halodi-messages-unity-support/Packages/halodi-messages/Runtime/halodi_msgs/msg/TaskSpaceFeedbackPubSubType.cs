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


      current_alignment += geometry_msgs.msg.Vector3PubSubType.getCdrSerializedSize(data.angular_acceleration, current_alignment);

      current_alignment += geometry_msgs.msg.Vector3PubSubType.getCdrSerializedSize(data.linear_acceleration, current_alignment);

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.passivity_output.Count; ++i0)
      {
          current_alignment += halodi_msgs.msg.PassivityDataPubSubType.getCdrSerializedSize(data.passivity_output[i0], current_alignment);}


      return current_alignment - initial_alignment;
   }

   public static void write(halodi_msgs.msg.TaskSpaceFeedback data, Halodi.CDR.CDRSerializer cdr)
   {
      halodi_msgs.msg.ReferenceFrameNamePubSubType.write(data.body_frame, cdr);

      halodi_msgs.msg.ReferenceFrameNamePubSubType.write(data.expressed_in_frame, cdr);

      cdr.write_type_7(data.express_in_z_up);

      geometry_msgs.msg.Vector3PubSubType.write(data.angular_acceleration, cdr);

      geometry_msgs.msg.Vector3PubSubType.write(data.linear_acceleration, cdr);

      	if(data.passivity_output == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int passivity_output_length = data.passivity_output.Count;
            cdr.write_type_2(passivity_output_length);
            for (int i0 = 0; i0 < passivity_output_length; i0++)
            {
      			halodi_msgs.msg.PassivityDataPubSubType.write(data.passivity_output[i0], cdr);	      }
        }
   }

   public static void read(halodi_msgs.msg.TaskSpaceFeedback data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.body_frame = halodi_msgs.msg.ReferenceFrameNamePubSubType.Create();
      halodi_msgs.msg.ReferenceFrameNamePubSubType.read(data.body_frame, cdr);
      	
      data.expressed_in_frame = halodi_msgs.msg.ReferenceFrameNamePubSubType.Create();
      halodi_msgs.msg.ReferenceFrameNamePubSubType.read(data.expressed_in_frame, cdr);
      	
      data.express_in_z_up=cdr.read_type_7();
      	
      data.angular_acceleration = geometry_msgs.msg.Vector3PubSubType.Create();
      geometry_msgs.msg.Vector3PubSubType.read(data.angular_acceleration, cdr);
      	
      data.linear_acceleration = geometry_msgs.msg.Vector3PubSubType.Create();
      geometry_msgs.msg.Vector3PubSubType.read(data.linear_acceleration, cdr);
      	

      int passivity_output_length = cdr.read_type_2();
      data.passivity_output = new System.Collections.Generic.List<halodi_msgs.msg.PassivityData>(passivity_output_length);
      for(int i = 0; i < passivity_output_length; i++)
      {
      	halodi_msgs.msg.PassivityData new_passivity_output = halodi_msgs.msg.PassivityDataPubSubType.Create(); 
      	halodi_msgs.msg.PassivityDataPubSubType.read(new_passivity_output, cdr);
      	data.passivity_output.Add(new_passivity_output);	
      	
      }

      	

   }


	public override void Serialize(halodi_msgs.msg.TaskSpaceFeedback data, Halodi.CDR.CDRSerializer cdr)
   	{
   		write(data, cdr);	
   	}

	public override void Deserialize(halodi_msgs.msg.TaskSpaceFeedback data, Halodi.CDR.CDRDeserializer cdr)
   	{
   		read(data, cdr);	
   	}
   	
   	public override int GetSize(halodi_msgs.msg.TaskSpaceFeedback data)
   	{
   		return getCdrSerializedSize(data);
   	}

    public static void Copy(halodi_msgs.msg.TaskSpaceFeedback src, halodi_msgs.msg.TaskSpaceFeedback target)
    {
        target.Set(src);
    }
    
    public override void CopyTo(halodi_msgs.msg.TaskSpaceFeedback src, halodi_msgs.msg.TaskSpaceFeedback target)
    {
    	Copy(src, target);
    }


}


}