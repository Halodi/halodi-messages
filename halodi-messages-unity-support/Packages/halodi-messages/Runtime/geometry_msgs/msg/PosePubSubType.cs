using System.IO;
namespace geometry_msgs.msg
{

/**
* 
* Topic data type of the struct "Pose" defined in "Pose.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from Pose.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit Pose.idl instead.
*
*/
public class PosePubSubType : Halodi.CDR.TopicDataType<Pose>
{
   public override string Name => "geometry_msgs::msg::dds_::Pose_";


   public static int getCdrSerializedSize(geometry_msgs.msg.Pose data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(geometry_msgs.msg.Pose data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += geometry_msgs.msg.PointPubSubType.getCdrSerializedSize(data.position, current_alignment);

      current_alignment += geometry_msgs.msg.QuaternionPubSubType.getCdrSerializedSize(data.orientation, current_alignment);


      return current_alignment - initial_alignment;
   }

   public static void write(geometry_msgs.msg.Pose data, Halodi.CDR.CDRSerializer cdr)
   {
      geometry_msgs.msg.PointPubSubType.write(data.position, cdr);

      geometry_msgs.msg.QuaternionPubSubType.write(data.orientation, cdr);

   }

   public static void read(geometry_msgs.msg.Pose data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.position = geometry_msgs.msg.PointPubSubType.Create();
      geometry_msgs.msg.PointPubSubType.read(data.position, cdr);
      	
      data.orientation = geometry_msgs.msg.QuaternionPubSubType.Create();
      geometry_msgs.msg.QuaternionPubSubType.read(data.orientation, cdr);
      	

   }


	public override void Serialize(geometry_msgs.msg.Pose data, Halodi.CDR.CDRSerializer cdr)
   	{
   		write(data, cdr);	
   	}

	public override void Deserialize(geometry_msgs.msg.Pose data, Halodi.CDR.CDRDeserializer cdr)
   	{
   		read(data, cdr);	
   	}
   	
   	public override int GetSize(geometry_msgs.msg.Pose data)
   	{
   		return getCdrSerializedSize(data);
   	}

    public static void Copy(geometry_msgs.msg.Pose src, geometry_msgs.msg.Pose target)
    {
        target.Set(src);
    }
    
    public override void CopyTo(geometry_msgs.msg.Pose src, geometry_msgs.msg.Pose target)
    {
    	Copy(src, target);
    }


}


}