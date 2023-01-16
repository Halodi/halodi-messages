using System.IO;
namespace geometry_msgs.msg
{

/**
* 
* Topic data type of the struct "TwistWithCovarianceStamped" defined in "TwistWithCovarianceStamped.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from TwistWithCovarianceStamped.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit TwistWithCovarianceStamped.idl instead.
*
*/
public class TwistWithCovarianceStampedPubSubType : Halodi.CDR.TopicDataType<TwistWithCovarianceStamped>
{
   public override string Name => "geometry_msgs::msg::dds_::TwistWithCovarianceStamped_";


   public static int getCdrSerializedSize(geometry_msgs.msg.TwistWithCovarianceStamped data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(geometry_msgs.msg.TwistWithCovarianceStamped data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += std_msgs.msg.HeaderPubSubType.getCdrSerializedSize(data.header, current_alignment);

      current_alignment += geometry_msgs.msg.TwistWithCovariancePubSubType.getCdrSerializedSize(data.twist, current_alignment);


      return current_alignment - initial_alignment;
   }

   public static void write(geometry_msgs.msg.TwistWithCovarianceStamped data, Halodi.CDR.CDRSerializer cdr)
   {
      std_msgs.msg.HeaderPubSubType.write(data.header, cdr);

      geometry_msgs.msg.TwistWithCovariancePubSubType.write(data.twist, cdr);

   }

   public static void read(geometry_msgs.msg.TwistWithCovarianceStamped data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.header = std_msgs.msg.HeaderPubSubType.Create();
      std_msgs.msg.HeaderPubSubType.read(data.header, cdr);
      	
      data.twist = geometry_msgs.msg.TwistWithCovariancePubSubType.Create();
      geometry_msgs.msg.TwistWithCovariancePubSubType.read(data.twist, cdr);
      	

   }


	public override void Serialize(geometry_msgs.msg.TwistWithCovarianceStamped data, Halodi.CDR.CDRSerializer cdr)
   	{
   		write(data, cdr);	
   	}

	public override void Deserialize(geometry_msgs.msg.TwistWithCovarianceStamped data, Halodi.CDR.CDRDeserializer cdr)
   	{
   		read(data, cdr);	
   	}
   	
   	public override int GetSize(geometry_msgs.msg.TwistWithCovarianceStamped data)
   	{
   		return getCdrSerializedSize(data);
   	}

    public static void Copy(geometry_msgs.msg.TwistWithCovarianceStamped src, geometry_msgs.msg.TwistWithCovarianceStamped target)
    {
        target.Set(src);
    }
    
    public override void CopyTo(geometry_msgs.msg.TwistWithCovarianceStamped src, geometry_msgs.msg.TwistWithCovarianceStamped target)
    {
    	Copy(src, target);
    }


}


}