using System.IO;
namespace geometry_msgs.msg
{

/**
* 
* Topic data type of the struct "Transform" defined in "Transform.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from Transform.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit Transform.idl instead.
*
*/
public class TransformPubSubType : Halodi.CDR.TopicDataType<Transform>
{
   public override string Name => "geometry_msgs::msg::dds_::Transform_";


   
   public override void serialize(geometry_msgs.msg.Transform data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, geometry_msgs.msg.Transform data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(geometry_msgs.msg.Transform data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(geometry_msgs.msg.Transform data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += geometry_msgs.msg.Vector3PubSubType.getCdrSerializedSize(data.translation, current_alignment);

      current_alignment += geometry_msgs.msg.QuaternionPubSubType.getCdrSerializedSize(data.rotation, current_alignment);


      return current_alignment - initial_alignment;
   }

   public static void write(geometry_msgs.msg.Transform data, Halodi.CDR.CDRSerializer cdr)
   {
      geometry_msgs.msg.Vector3PubSubType.write(data.translation, cdr);

      geometry_msgs.msg.QuaternionPubSubType.write(data.rotation, cdr);

   }

   public static void read(geometry_msgs.msg.Transform data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.translation = geometry_msgs.msg.Vector3PubSubType.Create();
      geometry_msgs.msg.Vector3PubSubType.read(data.translation, cdr);
      	
      data.rotation = geometry_msgs.msg.QuaternionPubSubType.Create();
      geometry_msgs.msg.QuaternionPubSubType.read(data.rotation, cdr);
      	

   }


    public static void Copy(geometry_msgs.msg.Transform src, geometry_msgs.msg.Transform target)
    {
        target.Set(src);
    }


}


}