using System.IO;
namespace nav_msgs.msg
{

/**
* 
* Topic data type of the struct "GridCells" defined in "GridCells.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from GridCells.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit GridCells.idl instead.
*
*/
public class GridCellsPubSubType : Halodi.CDR.TopicDataType<nav_msgs.msg.GridCells>
{
   public override string Name => "nav_msgs::msg::dds_::GridCells_";


   
   public override void serialize(nav_msgs.msg.GridCells data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, nav_msgs.msg.GridCells data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(nav_msgs.msg.GridCells data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(nav_msgs.msg.GridCells data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += std_msgs.msg.HeaderPubSubType.getCdrSerializedSize(data.header, current_alignment);

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.cells.Count; ++i0)
      {
          current_alignment += geometry_msgs.msg.PointPubSubType.getCdrSerializedSize(data.cells[i0], current_alignment);}


      return current_alignment - initial_alignment;
   }

   public static void write(nav_msgs.msg.GridCells data, Halodi.CDR.CDRSerializer cdr)
   {
      std_msgs.msg.HeaderPubSubType.write(data.header, cdr);

      cdr.write_type_5(data.cell_width);

      cdr.write_type_5(data.cell_height);

      	if(data.cells == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int cells_length = data.cells.Count;
            cdr.write_type_2(cells_length);
            for (int i0 = 0; i0 < cells_length; i0++)
            {
      			geometry_msgs.msg.PointPubSubType.write(data.cells[i0], cdr);	      }
        }
   }

   public static void read(nav_msgs.msg.GridCells data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.header = std_msgs.msg.HeaderPubSubType.Create();
      std_msgs.msg.HeaderPubSubType.read(data.header, cdr);
      	
      data.cell_width=cdr.read_type_5();
      	
      data.cell_height=cdr.read_type_5();
      	

      int cells_length = cdr.read_type_2();
      data.cells = new System.Collections.Generic.List<geometry_msgs.msg.Point>(cells_length);
      for(int i = 0; i < cells_length; i++)
      {
      	geometry_msgs.msg.Point new_cells = geometry_msgs.msg.PointPubSubType.Create(); 
      	geometry_msgs.msg.PointPubSubType.read(new_cells, cdr);
      	data.cells.Add(new_cells);	
      	
      }

      	

   }


    public static void Copy(nav_msgs.msg.GridCells src, nav_msgs.msg.GridCells target)
    {
        target.Set(src);
    }


}


}