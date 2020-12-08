// generated from rosidl_generator_cpp/resource/idl__struct.hpp.em
// with input from halodi_msgs:msg/WholeBodyTrajectoryPoint.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__MSG__WHOLE_BODY_TRAJECTORY_POINT__STRUCT_HPP_
#define HALODI_MSGS__MSG__WHOLE_BODY_TRAJECTORY_POINT__STRUCT_HPP_

#include <rosidl_generator_cpp/bounded_vector.hpp>
#include <rosidl_generator_cpp/message_initialization.hpp>
#include <algorithm>
#include <array>
#include <memory>
#include <string>
#include <vector>


// Include directives for member types
// Member 'time_from_start'
#include "builtin_interfaces/msg/duration__struct.hpp"
// Member 'task_space_commands'
#include "halodi_msgs/msg/task_space_command__struct.hpp"
// Member 'joint_space_commands'
#include "halodi_msgs/msg/joint_space_command__struct.hpp"
// Member 'contact_point_commands'
#include "halodi_msgs/msg/contact_point_command__struct.hpp"
// Member 'icp_offset_command'
#include "geometry_msgs/msg/vector3__struct.hpp"

#ifndef _WIN32
# define DEPRECATED__halodi_msgs__msg__WholeBodyTrajectoryPoint __attribute__((deprecated))
#else
# define DEPRECATED__halodi_msgs__msg__WholeBodyTrajectoryPoint __declspec(deprecated)
#endif

namespace halodi_msgs
{

namespace msg
{

// message struct
template<class ContainerAllocator>
struct WholeBodyTrajectoryPoint_
{
  using Type = WholeBodyTrajectoryPoint_<ContainerAllocator>;

  explicit WholeBodyTrajectoryPoint_(rosidl_generator_cpp::MessageInitialization _init = rosidl_generator_cpp::MessageInitialization::ALL)
  : time_from_start(_init)
  {
    (void)_init;
  }

  explicit WholeBodyTrajectoryPoint_(const ContainerAllocator & _alloc, rosidl_generator_cpp::MessageInitialization _init = rosidl_generator_cpp::MessageInitialization::ALL)
  : time_from_start(_alloc, _init)
  {
    (void)_init;
  }

  // field types and members
  using _time_from_start_type =
    builtin_interfaces::msg::Duration_<ContainerAllocator>;
  _time_from_start_type time_from_start;
  using _task_space_commands_type =
    rosidl_generator_cpp::BoundedVector<halodi_msgs::msg::TaskSpaceCommand_<ContainerAllocator>, 5, typename ContainerAllocator::template rebind<halodi_msgs::msg::TaskSpaceCommand_<ContainerAllocator>>::other>;
  _task_space_commands_type task_space_commands;
  using _joint_space_commands_type =
    rosidl_generator_cpp::BoundedVector<halodi_msgs::msg::JointSpaceCommand_<ContainerAllocator>, 25, typename ContainerAllocator::template rebind<halodi_msgs::msg::JointSpaceCommand_<ContainerAllocator>>::other>;
  _joint_space_commands_type joint_space_commands;
  using _contact_point_commands_type =
    rosidl_generator_cpp::BoundedVector<halodi_msgs::msg::ContactPointCommand_<ContainerAllocator>, 5, typename ContainerAllocator::template rebind<halodi_msgs::msg::ContactPointCommand_<ContainerAllocator>>::other>;
  _contact_point_commands_type contact_point_commands;
  using _icp_offset_command_type =
    rosidl_generator_cpp::BoundedVector<geometry_msgs::msg::Vector3_<ContainerAllocator>, 1, typename ContainerAllocator::template rebind<geometry_msgs::msg::Vector3_<ContainerAllocator>>::other>;
  _icp_offset_command_type icp_offset_command;

  // setters for named parameter idiom
  Type & set__time_from_start(
    const builtin_interfaces::msg::Duration_<ContainerAllocator> & _arg)
  {
    this->time_from_start = _arg;
    return *this;
  }
  Type & set__task_space_commands(
    const rosidl_generator_cpp::BoundedVector<halodi_msgs::msg::TaskSpaceCommand_<ContainerAllocator>, 5, typename ContainerAllocator::template rebind<halodi_msgs::msg::TaskSpaceCommand_<ContainerAllocator>>::other> & _arg)
  {
    this->task_space_commands = _arg;
    return *this;
  }
  Type & set__joint_space_commands(
    const rosidl_generator_cpp::BoundedVector<halodi_msgs::msg::JointSpaceCommand_<ContainerAllocator>, 25, typename ContainerAllocator::template rebind<halodi_msgs::msg::JointSpaceCommand_<ContainerAllocator>>::other> & _arg)
  {
    this->joint_space_commands = _arg;
    return *this;
  }
  Type & set__contact_point_commands(
    const rosidl_generator_cpp::BoundedVector<halodi_msgs::msg::ContactPointCommand_<ContainerAllocator>, 5, typename ContainerAllocator::template rebind<halodi_msgs::msg::ContactPointCommand_<ContainerAllocator>>::other> & _arg)
  {
    this->contact_point_commands = _arg;
    return *this;
  }
  Type & set__icp_offset_command(
    const rosidl_generator_cpp::BoundedVector<geometry_msgs::msg::Vector3_<ContainerAllocator>, 1, typename ContainerAllocator::template rebind<geometry_msgs::msg::Vector3_<ContainerAllocator>>::other> & _arg)
  {
    this->icp_offset_command = _arg;
    return *this;
  }

  // constant declarations

  // pointer types
  using RawPtr =
    halodi_msgs::msg::WholeBodyTrajectoryPoint_<ContainerAllocator> *;
  using ConstRawPtr =
    const halodi_msgs::msg::WholeBodyTrajectoryPoint_<ContainerAllocator> *;
  using SharedPtr =
    std::shared_ptr<halodi_msgs::msg::WholeBodyTrajectoryPoint_<ContainerAllocator>>;
  using ConstSharedPtr =
    std::shared_ptr<halodi_msgs::msg::WholeBodyTrajectoryPoint_<ContainerAllocator> const>;

  template<typename Deleter = std::default_delete<
      halodi_msgs::msg::WholeBodyTrajectoryPoint_<ContainerAllocator>>>
  using UniquePtrWithDeleter =
    std::unique_ptr<halodi_msgs::msg::WholeBodyTrajectoryPoint_<ContainerAllocator>, Deleter>;

  using UniquePtr = UniquePtrWithDeleter<>;

  template<typename Deleter = std::default_delete<
      halodi_msgs::msg::WholeBodyTrajectoryPoint_<ContainerAllocator>>>
  using ConstUniquePtrWithDeleter =
    std::unique_ptr<halodi_msgs::msg::WholeBodyTrajectoryPoint_<ContainerAllocator> const, Deleter>;
  using ConstUniquePtr = ConstUniquePtrWithDeleter<>;

  using WeakPtr =
    std::weak_ptr<halodi_msgs::msg::WholeBodyTrajectoryPoint_<ContainerAllocator>>;
  using ConstWeakPtr =
    std::weak_ptr<halodi_msgs::msg::WholeBodyTrajectoryPoint_<ContainerAllocator> const>;

  // pointer types similar to ROS 1, use SharedPtr / ConstSharedPtr instead
  // NOTE: Can't use 'using' here because GNU C++ can't parse attributes properly
  typedef DEPRECATED__halodi_msgs__msg__WholeBodyTrajectoryPoint
    std::shared_ptr<halodi_msgs::msg::WholeBodyTrajectoryPoint_<ContainerAllocator>>
    Ptr;
  typedef DEPRECATED__halodi_msgs__msg__WholeBodyTrajectoryPoint
    std::shared_ptr<halodi_msgs::msg::WholeBodyTrajectoryPoint_<ContainerAllocator> const>
    ConstPtr;

  // comparison operators
  bool operator==(const WholeBodyTrajectoryPoint_ & other) const
  {
    if (this->time_from_start != other.time_from_start) {
      return false;
    }
    if (this->task_space_commands != other.task_space_commands) {
      return false;
    }
    if (this->joint_space_commands != other.joint_space_commands) {
      return false;
    }
    if (this->contact_point_commands != other.contact_point_commands) {
      return false;
    }
    if (this->icp_offset_command != other.icp_offset_command) {
      return false;
    }
    return true;
  }
  bool operator!=(const WholeBodyTrajectoryPoint_ & other) const
  {
    return !this->operator==(other);
  }
};  // struct WholeBodyTrajectoryPoint_

// alias to use template instance with default allocator
using WholeBodyTrajectoryPoint =
  halodi_msgs::msg::WholeBodyTrajectoryPoint_<std::allocator<void>>;

// constant definitions

}  // namespace msg

}  // namespace halodi_msgs

#endif  // HALODI_MSGS__MSG__WHOLE_BODY_TRAJECTORY_POINT__STRUCT_HPP_
