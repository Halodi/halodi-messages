using System.IO;
namespace halodi_msgs.msg
{

/**
* 
* Topic data type of the struct "RobotPoseEstimateConfiguration" defined in "RobotPoseEstimateConfiguration.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from RobotPoseEstimateConfiguration.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit RobotPoseEstimateConfiguration.idl instead.
*
*/
public class RobotPoseEstimateConfigurationPubSubType : Halodi.CDR.TopicDataType<RobotPoseEstimateConfiguration>
{
   public override string Name => "halodi_msgs::msg::dds_::RobotPoseEstimateConfiguration_";


   public static int getCdrSerializedSize(halodi_msgs.msg.RobotPoseEstimateConfiguration data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(halodi_msgs.msg.RobotPoseEstimateConfiguration data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += halodi_msgs.msg.ReferenceFrameNamePubSubType.getCdrSerializedSize(data.parent_frame, current_alignment);

      current_alignment += geometry_msgs.msg.TransformPubSubType.getCdrSerializedSize(data.static_transform, current_alignment);

      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);



      return current_alignment - initial_alignment;
   }

   public static void write(halodi_msgs.msg.RobotPoseEstimateConfiguration data, Halodi.CDR.CDRSerializer cdr)
   {
      halodi_msgs.msg.ReferenceFrameNamePubSubType.write(data.parent_frame, cdr);

      geometry_msgs.msg.TransformPubSubType.write(data.static_transform, cdr);

      cdr.write_type_6(data.alpha);

   }

   public static void read(halodi_msgs.msg.RobotPoseEstimateConfiguration data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.parent_frame = halodi_msgs.msg.ReferenceFrameNamePubSubType.Create();
      halodi_msgs.msg.ReferenceFrameNamePubSubType.read(data.parent_frame, cdr);
      	
      data.static_transform = geometry_msgs.msg.TransformPubSubType.Create();
      geometry_msgs.msg.TransformPubSubType.read(data.static_transform, cdr);
      	
      data.alpha=cdr.read_type_6();
      	

   }


	public override void Serialize(halodi_msgs.msg.RobotPoseEstimateConfiguration data, Halodi.CDR.CDRSerializer cdr)
   	{
   		write(data, cdr);	
   	}

	public override void Deserialize(halodi_msgs.msg.RobotPoseEstimateConfiguration data, Halodi.CDR.CDRDeserializer cdr)
   	{
   		read(data, cdr);	
   	}
   	
   	public override int GetSize(halodi_msgs.msg.RobotPoseEstimateConfiguration data)
   	{
   		return getCdrSerializedSize(data);
   	}

    public static void Copy(halodi_msgs.msg.RobotPoseEstimateConfiguration src, halodi_msgs.msg.RobotPoseEstimateConfiguration target)
    {
        target.Set(src);
    }
    
    public override void CopyTo(halodi_msgs.msg.RobotPoseEstimateConfiguration src, halodi_msgs.msg.RobotPoseEstimateConfiguration target)
    {
    	Copy(src, target);
    }


}


}