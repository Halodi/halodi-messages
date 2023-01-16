using System.IO;
namespace geometry_msgs.msg
{

/**
* 
* Topic data type of the struct "Vector3Stamped" defined in "Vector3Stamped.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from Vector3Stamped.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit Vector3Stamped.idl instead.
*
*/
public class Vector3StampedPubSubType : Halodi.CDR.TopicDataType<Vector3Stamped>
{
   public override string Name => "geometry_msgs::msg::dds_::Vector3Stamped_";


   public static int getCdrSerializedSize(geometry_msgs.msg.Vector3Stamped data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(geometry_msgs.msg.Vector3Stamped data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += std_msgs.msg.HeaderPubSubType.getCdrSerializedSize(data.header, current_alignment);

      current_alignment += geometry_msgs.msg.Vector3PubSubType.getCdrSerializedSize(data.vector, current_alignment);


      return current_alignment - initial_alignment;
   }

   public static void write(geometry_msgs.msg.Vector3Stamped data, Halodi.CDR.CDRSerializer cdr)
   {
      std_msgs.msg.HeaderPubSubType.write(data.header, cdr);

      geometry_msgs.msg.Vector3PubSubType.write(data.vector, cdr);

   }

   public static void read(geometry_msgs.msg.Vector3Stamped data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.header = std_msgs.msg.HeaderPubSubType.Create();
      std_msgs.msg.HeaderPubSubType.read(data.header, cdr);
      	
      data.vector = geometry_msgs.msg.Vector3PubSubType.Create();
      geometry_msgs.msg.Vector3PubSubType.read(data.vector, cdr);
      	

   }


	public override void Serialize(geometry_msgs.msg.Vector3Stamped data, Halodi.CDR.CDRSerializer cdr)
   	{
   		write(data, cdr);	
   	}

	public override void Deserialize(geometry_msgs.msg.Vector3Stamped data, Halodi.CDR.CDRDeserializer cdr)
   	{
   		read(data, cdr);	
   	}
   	
   	public override int GetSize(geometry_msgs.msg.Vector3Stamped data)
   	{
   		return getCdrSerializedSize(data);
   	}

    public static void Copy(geometry_msgs.msg.Vector3Stamped src, geometry_msgs.msg.Vector3Stamped target)
    {
        target.Set(src);
    }
    
    public override void CopyTo(geometry_msgs.msg.Vector3Stamped src, geometry_msgs.msg.Vector3Stamped target)
    {
    	Copy(src, target);
    }


}


}