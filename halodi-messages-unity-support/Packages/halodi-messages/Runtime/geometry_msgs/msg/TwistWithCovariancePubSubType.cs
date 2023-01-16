using System.IO;
namespace geometry_msgs.msg
{

/**
* 
* Topic data type of the struct "TwistWithCovariance" defined in "TwistWithCovariance.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from TwistWithCovariance.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit TwistWithCovariance.idl instead.
*
*/
public class TwistWithCovariancePubSubType : Halodi.CDR.TopicDataType<TwistWithCovariance>
{
   public override string Name => "geometry_msgs::msg::dds_::TwistWithCovariance_";


   public static int getCdrSerializedSize(geometry_msgs.msg.TwistWithCovariance data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(geometry_msgs.msg.TwistWithCovariance data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += geometry_msgs.msg.TwistPubSubType.getCdrSerializedSize(data.twist, current_alignment);

      current_alignment += ((36) * 8) + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);

      return current_alignment - initial_alignment;
   }

   public static void write(geometry_msgs.msg.TwistWithCovariance data, Halodi.CDR.CDRSerializer cdr)
   {
      geometry_msgs.msg.TwistPubSubType.write(data.twist, cdr);

      for(int i0 = 0; i0 < 36; ++i0)
      {
        	cdr.write_type_6(data.covariance[i0]);	
      }

   }

   public static void read(geometry_msgs.msg.TwistWithCovariance data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.twist = geometry_msgs.msg.TwistPubSubType.Create();
      geometry_msgs.msg.TwistPubSubType.read(data.twist, cdr);
      	
      for(int i0 = 0; i0 < 36; ++i0)
      {
        	data.covariance[i0] = cdr.read_type_6();
        	
      }
      	

   }


	public override void Serialize(geometry_msgs.msg.TwistWithCovariance data, Halodi.CDR.CDRSerializer cdr)
   	{
   		write(data, cdr);	
   	}

	public override void Deserialize(geometry_msgs.msg.TwistWithCovariance data, Halodi.CDR.CDRDeserializer cdr)
   	{
   		read(data, cdr);	
   	}
   	
   	public override int GetSize(geometry_msgs.msg.TwistWithCovariance data)
   	{
   		return getCdrSerializedSize(data);
   	}

    public static void Copy(geometry_msgs.msg.TwistWithCovariance src, geometry_msgs.msg.TwistWithCovariance target)
    {
        target.Set(src);
    }
    
    public override void CopyTo(geometry_msgs.msg.TwistWithCovariance src, geometry_msgs.msg.TwistWithCovariance target)
    {
    	Copy(src, target);
    }


}


}