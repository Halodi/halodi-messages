// generated from rosidl_generator_cpp/resource/idl__struct.hpp.em
// with input from halodi_msgs:msg/TaskSpaceFeedback.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__MSG__TASK_SPACE_FEEDBACK__STRUCT_HPP_
#define HALODI_MSGS__MSG__TASK_SPACE_FEEDBACK__STRUCT_HPP_

#include <rosidl_generator_cpp/bounded_vector.hpp>
#include <rosidl_generator_cpp/message_initialization.hpp>
#include <algorithm>
#include <array>
#include <memory>
#include <string>
#include <vector>


// Include directives for member types
// Member 'body_frame'
// Member 'expressed_in_frame'
#include "halodi_msgs/msg/reference_frame_name__struct.hpp"
// Member 'angular_acceleration'
// Member 'linear_acceleration'
#include "geometry_msgs/msg/vector3__struct.hpp"
// Member 'passivity_output'
#include "halodi_msgs/msg/passivity_data__struct.hpp"

#ifndef _WIN32
# define DEPRECATED__halodi_msgs__msg__TaskSpaceFeedback __attribute__((deprecated))
#else
# define DEPRECATED__halodi_msgs__msg__TaskSpaceFeedback __declspec(deprecated)
#endif

namespace halodi_msgs
{

namespace msg
{

// message struct
template<class ContainerAllocator>
struct TaskSpaceFeedback_
{
  using Type = TaskSpaceFeedback_<ContainerAllocator>;

  explicit TaskSpaceFeedback_(rosidl_generator_cpp::MessageInitialization _init = rosidl_generator_cpp::MessageInitialization::ALL)
  : body_frame(_init),
    expressed_in_frame(_init),
    angular_acceleration(_init),
    linear_acceleration(_init)
  {
    if (rosidl_generator_cpp::MessageInitialization::ALL == _init ||
      rosidl_generator_cpp::MessageInitialization::ZERO == _init)
    {
      this->express_in_z_up = false;
    }
  }

  explicit TaskSpaceFeedback_(const ContainerAllocator & _alloc, rosidl_generator_cpp::MessageInitialization _init = rosidl_generator_cpp::MessageInitialization::ALL)
  : body_frame(_alloc, _init),
    expressed_in_frame(_alloc, _init),
    angular_acceleration(_alloc, _init),
    linear_acceleration(_alloc, _init)
  {
    if (rosidl_generator_cpp::MessageInitialization::ALL == _init ||
      rosidl_generator_cpp::MessageInitialization::ZERO == _init)
    {
      this->express_in_z_up = false;
    }
  }

  // field types and members
  using _body_frame_type =
    halodi_msgs::msg::ReferenceFrameName_<ContainerAllocator>;
  _body_frame_type body_frame;
  using _expressed_in_frame_type =
    halodi_msgs::msg::ReferenceFrameName_<ContainerAllocator>;
  _expressed_in_frame_type expressed_in_frame;
  using _express_in_z_up_type =
    bool;
  _express_in_z_up_type express_in_z_up;
  using _angular_acceleration_type =
    geometry_msgs::msg::Vector3_<ContainerAllocator>;
  _angular_acceleration_type angular_acceleration;
  using _linear_acceleration_type =
    geometry_msgs::msg::Vector3_<ContainerAllocator>;
  _linear_acceleration_type linear_acceleration;
  using _passivity_output_type =
    rosidl_generator_cpp::BoundedVector<halodi_msgs::msg::PassivityData_<ContainerAllocator>, 1, typename ContainerAllocator::template rebind<halodi_msgs::msg::PassivityData_<ContainerAllocator>>::other>;
  _passivity_output_type passivity_output;

  // setters for named parameter idiom
  Type & set__body_frame(
    const halodi_msgs::msg::ReferenceFrameName_<ContainerAllocator> & _arg)
  {
    this->body_frame = _arg;
    return *this;
  }
  Type & set__expressed_in_frame(
    const halodi_msgs::msg::ReferenceFrameName_<ContainerAllocator> & _arg)
  {
    this->expressed_in_frame = _arg;
    return *this;
  }
  Type & set__express_in_z_up(
    const bool & _arg)
  {
    this->express_in_z_up = _arg;
    return *this;
  }
  Type & set__angular_acceleration(
    const geometry_msgs::msg::Vector3_<ContainerAllocator> & _arg)
  {
    this->angular_acceleration = _arg;
    return *this;
  }
  Type & set__linear_acceleration(
    const geometry_msgs::msg::Vector3_<ContainerAllocator> & _arg)
  {
    this->linear_acceleration = _arg;
    return *this;
  }
  Type & set__passivity_output(
    const rosidl_generator_cpp::BoundedVector<halodi_msgs::msg::PassivityData_<ContainerAllocator>, 1, typename ContainerAllocator::template rebind<halodi_msgs::msg::PassivityData_<ContainerAllocator>>::other> & _arg)
  {
    this->passivity_output = _arg;
    return *this;
  }

  // constant declarations

  // pointer types
  using RawPtr =
    halodi_msgs::msg::TaskSpaceFeedback_<ContainerAllocator> *;
  using ConstRawPtr =
    const halodi_msgs::msg::TaskSpaceFeedback_<ContainerAllocator> *;
  using SharedPtr =
    std::shared_ptr<halodi_msgs::msg::TaskSpaceFeedback_<ContainerAllocator>>;
  using ConstSharedPtr =
    std::shared_ptr<halodi_msgs::msg::TaskSpaceFeedback_<ContainerAllocator> const>;

  template<typename Deleter = std::default_delete<
      halodi_msgs::msg::TaskSpaceFeedback_<ContainerAllocator>>>
  using UniquePtrWithDeleter =
    std::unique_ptr<halodi_msgs::msg::TaskSpaceFeedback_<ContainerAllocator>, Deleter>;

  using UniquePtr = UniquePtrWithDeleter<>;

  template<typename Deleter = std::default_delete<
      halodi_msgs::msg::TaskSpaceFeedback_<ContainerAllocator>>>
  using ConstUniquePtrWithDeleter =
    std::unique_ptr<halodi_msgs::msg::TaskSpaceFeedback_<ContainerAllocator> const, Deleter>;
  using ConstUniquePtr = ConstUniquePtrWithDeleter<>;

  using WeakPtr =
    std::weak_ptr<halodi_msgs::msg::TaskSpaceFeedback_<ContainerAllocator>>;
  using ConstWeakPtr =
    std::weak_ptr<halodi_msgs::msg::TaskSpaceFeedback_<ContainerAllocator> const>;

  // pointer types similar to ROS 1, use SharedPtr / ConstSharedPtr instead
  // NOTE: Can't use 'using' here because GNU C++ can't parse attributes properly
  typedef DEPRECATED__halodi_msgs__msg__TaskSpaceFeedback
    std::shared_ptr<halodi_msgs::msg::TaskSpaceFeedback_<ContainerAllocator>>
    Ptr;
  typedef DEPRECATED__halodi_msgs__msg__TaskSpaceFeedback
    std::shared_ptr<halodi_msgs::msg::TaskSpaceFeedback_<ContainerAllocator> const>
    ConstPtr;

  // comparison operators
  bool operator==(const TaskSpaceFeedback_ & other) const
  {
    if (this->body_frame != other.body_frame) {
      return false;
    }
    if (this->expressed_in_frame != other.expressed_in_frame) {
      return false;
    }
    if (this->express_in_z_up != other.express_in_z_up) {
      return false;
    }
    if (this->angular_acceleration != other.angular_acceleration) {
      return false;
    }
    if (this->linear_acceleration != other.linear_acceleration) {
      return false;
    }
    if (this->passivity_output != other.passivity_output) {
      return false;
    }
    return true;
  }
  bool operator!=(const TaskSpaceFeedback_ & other) const
  {
    return !this->operator==(other);
  }
};  // struct TaskSpaceFeedback_

// alias to use template instance with default allocator
using TaskSpaceFeedback =
  halodi_msgs::msg::TaskSpaceFeedback_<std::allocator<void>>;

// constant definitions

}  // namespace msg

}  // namespace halodi_msgs

#endif  // HALODI_MSGS__MSG__TASK_SPACE_FEEDBACK__STRUCT_HPP_
