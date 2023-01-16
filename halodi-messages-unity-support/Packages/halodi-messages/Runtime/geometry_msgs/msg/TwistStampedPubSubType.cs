using System.IO;
namespace geometry_msgs.msg
{

/**
* 
* Topic data type of the struct "TwistStamped" defined in "TwistStamped.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from TwistStamped.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit TwistStamped.idl instead.
*
*/
public class TwistStampedPubSubType : Halodi.CDR.TopicDataType<TwistStamped>
{
   public override string Name => "geometry_msgs::msg::dds_::TwistStamped_";


   public static int getCdrSerializedSize(geometry_msgs.msg.TwistStamped data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(geometry_msgs.msg.TwistStamped data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += std_msgs.msg.HeaderPubSubType.getCdrSerializedSize(data.header, current_alignment);

      current_alignment += geometry_msgs.msg.TwistPubSubType.getCdrSerializedSize(data.twist, current_alignment);


      return current_alignment - initial_alignment;
   }

   public static void write(geometry_msgs.msg.TwistStamped data, Halodi.CDR.CDRSerializer cdr)
   {
      std_msgs.msg.HeaderPubSubType.write(data.header, cdr);

      geometry_msgs.msg.TwistPubSubType.write(data.twist, cdr);

   }

   public static void read(geometry_msgs.msg.TwistStamped data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.header = std_msgs.msg.HeaderPubSubType.Create();
      std_msgs.msg.HeaderPubSubType.read(data.header, cdr);
      	
      data.twist = geometry_msgs.msg.TwistPubSubType.Create();
      geometry_msgs.msg.TwistPubSubType.read(data.twist, cdr);
      	

   }


	public override void Serialize(geometry_msgs.msg.TwistStamped data, Halodi.CDR.CDRSerializer cdr)
   	{
   		write(data, cdr);	
   	}

	public override void Deserialize(geometry_msgs.msg.TwistStamped data, Halodi.CDR.CDRDeserializer cdr)
   	{
   		read(data, cdr);	
   	}
   	
   	public override int GetSize(geometry_msgs.msg.TwistStamped data)
   	{
   		return getCdrSerializedSize(data);
   	}

    public static void Copy(geometry_msgs.msg.TwistStamped src, geometry_msgs.msg.TwistStamped target)
    {
        target.Set(src);
    }
    
    public override void CopyTo(geometry_msgs.msg.TwistStamped src, geometry_msgs.msg.TwistStamped target)
    {
    	Copy(src, target);
    }


}


}