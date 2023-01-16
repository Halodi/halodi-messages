using System.IO;
namespace geometry_msgs.msg
{

/**
* 
* Topic data type of the struct "QuaternionStamped" defined in "QuaternionStamped.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from QuaternionStamped.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit QuaternionStamped.idl instead.
*
*/
public class QuaternionStampedPubSubType : Halodi.CDR.TopicDataType<QuaternionStamped>
{
   public override string Name => "geometry_msgs::msg::dds_::QuaternionStamped_";


   public static int getCdrSerializedSize(geometry_msgs.msg.QuaternionStamped data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(geometry_msgs.msg.QuaternionStamped data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += std_msgs.msg.HeaderPubSubType.getCdrSerializedSize(data.header, current_alignment);

      current_alignment += geometry_msgs.msg.QuaternionPubSubType.getCdrSerializedSize(data.quaternion, current_alignment);


      return current_alignment - initial_alignment;
   }

   public static void write(geometry_msgs.msg.QuaternionStamped data, Halodi.CDR.CDRSerializer cdr)
   {
      std_msgs.msg.HeaderPubSubType.write(data.header, cdr);

      geometry_msgs.msg.QuaternionPubSubType.write(data.quaternion, cdr);

   }

   public static void read(geometry_msgs.msg.QuaternionStamped data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.header = std_msgs.msg.HeaderPubSubType.Create();
      std_msgs.msg.HeaderPubSubType.read(data.header, cdr);
      	
      data.quaternion = geometry_msgs.msg.QuaternionPubSubType.Create();
      geometry_msgs.msg.QuaternionPubSubType.read(data.quaternion, cdr);
      	

   }


	public override void Serialize(geometry_msgs.msg.QuaternionStamped data, Halodi.CDR.CDRSerializer cdr)
   	{
   		write(data, cdr);	
   	}

	public override void Deserialize(geometry_msgs.msg.QuaternionStamped data, Halodi.CDR.CDRDeserializer cdr)
   	{
   		read(data, cdr);	
   	}
   	
   	public override int GetSize(geometry_msgs.msg.QuaternionStamped data)
   	{
   		return getCdrSerializedSize(data);
   	}

    public static void Copy(geometry_msgs.msg.QuaternionStamped src, geometry_msgs.msg.QuaternionStamped target)
    {
        target.Set(src);
    }
    
    public override void CopyTo(geometry_msgs.msg.QuaternionStamped src, geometry_msgs.msg.QuaternionStamped target)
    {
    	Copy(src, target);
    }


}


}