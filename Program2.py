#P7049
#Section 1
#Program 2
#Oct 20th
#Creates a chart based off grades entered

# -*- coding: utf-8 -*-
import matplotlib.pyplot as plt
import numpy as np
import seaborn as sns
import statistics 

#Define number of students and tests
def input_test_scores():
    num_students = int(input("Insert amount of Students: "))
    num_tests = int(input("Insert amount of Tests: "))
    
    li_scores = []
    for stu in range(0, num_students):
        tests = []
        for test in range(0, num_tests):
            test_score = float(input(f"For student number {stu+1} input test {test+1} score: "))
            tests.append(test_score)
        li_scores.append(tests)
    return li_scores

#Chnage grades to averages and create chart
def summarize_test_scores(li_scores):
    for i in range(len(li_scores)):
        li_scores[i] = statistics.mean(li_scores[i])
    print(li_scores)
    for score in range(0, len(li_scores)):
        if li_scores[score] >= 90:
            li_scores[score] = 'A'
        elif li_scores[score] >= 80:
            li_scores[score] = 'B'
        elif li_scores[score] >= 70:
            li_scores[score] = 'C'
        elif li_scores[score] >= 60:
            li_scores[score] = 'D'
        else:
            li_scores[score] = 'F'
            
    grades, frequencies = np.unique(li_scores, return_counts=True)
            
    title = f'Grades for {len(li_scores):,} Students'


    sns.set_style('whitegrid')  # default is white with no grid


    # create and display the bar plot
    axes = sns.barplot(x=grades, y=frequencies, palette='bright')
    
    
    # set the title of the plot
    axes.set_title(title)
    
    
    # label the axes
    axes.set(xlabel='Grades', ylabel='Frequency')  
    
    
    # scale the y-axis to add room for text above bars
    axes.set_ylim(top=max(frequencies) * 1.10)
    
    
    # create and display the text for each bar
    for bar, frequency in zip(axes.patches, frequencies):
        text_x = bar.get_x() + bar.get_width() / 2.0  
        text_y = bar.get_height() 
        text = f'{frequency:,}\n{frequency / len(li_scores):.3%}'
        axes.text(text_x, text_y, text, 
                  fontsize=11, ha='center', va='bottom')    
    
    return li_scores 


summarize_test_scores(input_test_scores())