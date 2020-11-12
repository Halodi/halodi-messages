using System.IO;
namespace geometry_msgs.msg
{

/**
* 
* Topic data type of the struct "Wrench" defined in "Wrench.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from Wrench.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit Wrench.idl instead.
*
*/
public class WrenchPubSubType : Halodi.CDR.TopicDataType<geometry_msgs.msg.Wrench>
{
   public override string Name => "geometry_msgs::msg::dds_::Wrench_";


   
   public override void serialize(geometry_msgs.msg.Wrench data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, geometry_msgs.msg.Wrench data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(geometry_msgs.msg.Wrench data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(geometry_msgs.msg.Wrench data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += geometry_msgs.msg.Vector3PubSubType.getCdrSerializedSize(data.force, current_alignment);

      current_alignment += geometry_msgs.msg.Vector3PubSubType.getCdrSerializedSize(data.torque, current_alignment);


      return current_alignment - initial_alignment;
   }

   public static void write(geometry_msgs.msg.Wrench data, Halodi.CDR.CDRSerializer cdr)
   {
      geometry_msgs.msg.Vector3PubSubType.write(data.force, cdr);

      geometry_msgs.msg.Vector3PubSubType.write(data.torque, cdr);

   }

   public static void read(geometry_msgs.msg.Wrench data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.force = geometry_msgs.msg.Vector3PubSubType.Create();
      geometry_msgs.msg.Vector3PubSubType.read(data.force, cdr);
      	
      data.torque = geometry_msgs.msg.Vector3PubSubType.Create();
      geometry_msgs.msg.Vector3PubSubType.read(data.torque, cdr);
      	

   }


    public static void Copy(geometry_msgs.msg.Wrench src, geometry_msgs.msg.Wrench target)
    {
        target.Set(src);
    }


}


}