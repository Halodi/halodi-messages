using System.IO;
namespace geometry_msgs.msg
{

/**
* 
* Topic data type of the struct "PoseWithCovariance" defined in "PoseWithCovariance.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from PoseWithCovariance.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit PoseWithCovariance.idl instead.
*
*/
public class PoseWithCovariancePubSubType : Halodi.CDR.TopicDataType<PoseWithCovariance>
{
   public override string Name => "geometry_msgs::msg::dds_::PoseWithCovariance_";


   public static int getCdrSerializedSize(geometry_msgs.msg.PoseWithCovariance data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(geometry_msgs.msg.PoseWithCovariance data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += geometry_msgs.msg.PosePubSubType.getCdrSerializedSize(data.pose, current_alignment);

      current_alignment += ((36) * 8) + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);

      return current_alignment - initial_alignment;
   }

   public static void write(geometry_msgs.msg.PoseWithCovariance data, Halodi.CDR.CDRSerializer cdr)
   {
      geometry_msgs.msg.PosePubSubType.write(data.pose, cdr);

      for(int i0 = 0; i0 < 36; ++i0)
      {
        	cdr.write_type_6(data.covariance[i0]);	
      }

   }

   public static void read(geometry_msgs.msg.PoseWithCovariance data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.pose = geometry_msgs.msg.PosePubSubType.Create();
      geometry_msgs.msg.PosePubSubType.read(data.pose, cdr);
      	
      for(int i0 = 0; i0 < 36; ++i0)
      {
        	data.covariance[i0] = cdr.read_type_6();
        	
      }
      	

   }


	public override void Serialize(geometry_msgs.msg.PoseWithCovariance data, Halodi.CDR.CDRSerializer cdr)
   	{
   		write(data, cdr);	
   	}

	public override void Deserialize(geometry_msgs.msg.PoseWithCovariance data, Halodi.CDR.CDRDeserializer cdr)
   	{
   		read(data, cdr);	
   	}
   	
   	public override int GetSize(geometry_msgs.msg.PoseWithCovariance data)
   	{
   		return getCdrSerializedSize(data);
   	}

    public static void Copy(geometry_msgs.msg.PoseWithCovariance src, geometry_msgs.msg.PoseWithCovariance target)
    {
        target.Set(src);
    }
    
    public override void CopyTo(geometry_msgs.msg.PoseWithCovariance src, geometry_msgs.msg.PoseWithCovariance target)
    {
    	Copy(src, target);
    }


}


}