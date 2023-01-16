using System.IO;
namespace visualization_msgs.msg
{

/**
* 
* Topic data type of the struct "InteractiveMarkerPose" defined in "InteractiveMarkerPose.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from InteractiveMarkerPose.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit InteractiveMarkerPose.idl instead.
*
*/
public class InteractiveMarkerPosePubSubType : Halodi.CDR.TopicDataType<InteractiveMarkerPose>
{
   public override string Name => "visualization_msgs::msg::dds_::InteractiveMarkerPose_";


   public static int getCdrSerializedSize(visualization_msgs.msg.InteractiveMarkerPose data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(visualization_msgs.msg.InteractiveMarkerPose data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += std_msgs.msg.HeaderPubSubType.getCdrSerializedSize(data.header, current_alignment);

      current_alignment += geometry_msgs.msg.PosePubSubType.getCdrSerializedSize(data.pose, current_alignment);

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.name.Length + 1;


      return current_alignment - initial_alignment;
   }

   public static void write(visualization_msgs.msg.InteractiveMarkerPose data, Halodi.CDR.CDRSerializer cdr)
   {
      std_msgs.msg.HeaderPubSubType.write(data.header, cdr);

      geometry_msgs.msg.PosePubSubType.write(data.pose, cdr);

      cdr.write_type_d(data.name);

   }

   public static void read(visualization_msgs.msg.InteractiveMarkerPose data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.header = std_msgs.msg.HeaderPubSubType.Create();
      std_msgs.msg.HeaderPubSubType.read(data.header, cdr);
      	
      data.pose = geometry_msgs.msg.PosePubSubType.Create();
      geometry_msgs.msg.PosePubSubType.read(data.pose, cdr);
      	
      data.name = cdr.read_type_d();	

   }


	public override void Serialize(visualization_msgs.msg.InteractiveMarkerPose data, Halodi.CDR.CDRSerializer cdr)
   	{
   		write(data, cdr);	
   	}

	public override void Deserialize(visualization_msgs.msg.InteractiveMarkerPose data, Halodi.CDR.CDRDeserializer cdr)
   	{
   		read(data, cdr);	
   	}
   	
   	public override int GetSize(visualization_msgs.msg.InteractiveMarkerPose data)
   	{
   		return getCdrSerializedSize(data);
   	}

    public static void Copy(visualization_msgs.msg.InteractiveMarkerPose src, visualization_msgs.msg.InteractiveMarkerPose target)
    {
        target.Set(src);
    }
    
    public override void CopyTo(visualization_msgs.msg.InteractiveMarkerPose src, visualization_msgs.msg.InteractiveMarkerPose target)
    {
    	Copy(src, target);
    }


}


}