using System.IO;
namespace geometry_msgs.msg
{

/**
* 
* Topic data type of the struct "WrenchStamped" defined in "WrenchStamped.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from WrenchStamped.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit WrenchStamped.idl instead.
*
*/
public class WrenchStampedPubSubType : Halodi.CDR.TopicDataType<WrenchStamped>
{
   public override string Name => "geometry_msgs::msg::dds_::WrenchStamped_";


   public static int getCdrSerializedSize(geometry_msgs.msg.WrenchStamped data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(geometry_msgs.msg.WrenchStamped data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += std_msgs.msg.HeaderPubSubType.getCdrSerializedSize(data.header, current_alignment);

      current_alignment += geometry_msgs.msg.WrenchPubSubType.getCdrSerializedSize(data.wrench, current_alignment);


      return current_alignment - initial_alignment;
   }

   public static void write(geometry_msgs.msg.WrenchStamped data, Halodi.CDR.CDRSerializer cdr)
   {
      std_msgs.msg.HeaderPubSubType.write(data.header, cdr);

      geometry_msgs.msg.WrenchPubSubType.write(data.wrench, cdr);

   }

   public static void read(geometry_msgs.msg.WrenchStamped data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.header = std_msgs.msg.HeaderPubSubType.Create();
      std_msgs.msg.HeaderPubSubType.read(data.header, cdr);
      	
      data.wrench = geometry_msgs.msg.WrenchPubSubType.Create();
      geometry_msgs.msg.WrenchPubSubType.read(data.wrench, cdr);
      	

   }


	public override void Serialize(geometry_msgs.msg.WrenchStamped data, Halodi.CDR.CDRSerializer cdr)
   	{
   		write(data, cdr);	
   	}

	public override void Deserialize(geometry_msgs.msg.WrenchStamped data, Halodi.CDR.CDRDeserializer cdr)
   	{
   		read(data, cdr);	
   	}
   	
   	public override int GetSize(geometry_msgs.msg.WrenchStamped data)
   	{
   		return getCdrSerializedSize(data);
   	}

    public static void Copy(geometry_msgs.msg.WrenchStamped src, geometry_msgs.msg.WrenchStamped target)
    {
        target.Set(src);
    }
    
    public override void CopyTo(geometry_msgs.msg.WrenchStamped src, geometry_msgs.msg.WrenchStamped target)
    {
    	Copy(src, target);
    }


}


}