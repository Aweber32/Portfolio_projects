#P7049
#CIS 443
#Dec 2
#Prog4
#Runs text blobs setiment analyser and compares to the star reviews to see if they are in agreement 

import pandas as pd
from textblob import TextBlob, Blobber
from textblob.sentiments import NaiveBayesAnalyzer

#initialize table and build dataframe
trip_advisor_csv = pd.read_csv('tripadvisor_hotel_reviews.csv') 
trip_advisor_df = pd.DataFrame(trip_advisor_csv)

#Run textblob sentiment on the reviews, assign a label and add to df
x = 'n/a'
def review_set(df_row):
    data = TextBlob(df_row['Review']).sentiment
    if data[0] < -0.05:
        x = 'Negative'
    elif data[0] > 0.05:
        x = 'Positive'
    else:
        x = 'Neutral'
    return x
trip_advisor_df['Review_Sentiment'] = trip_advisor_df.apply(review_set, axis=1)

#Assign label to each star rating and add to df
y = 'n/a'
def rating_set(df_row):
    record = df_row['Rating']
    if record > 3:
        y = 'Positive'
    elif record < 3:
        y = 'Negative'
    else:
        y = 'Neutral'
    return y
trip_advisor_df['Rating_Sentiment'] = trip_advisor_df.apply(rating_set, axis=1)

#Determine review and rating agreement and add to df
z = 'n/a'
def review_rating_agreement(df_row):
    review = df_row['Review_Sentiment']
    rating = df_row['Rating_Sentiment']
    if review == rating:
        z = True
    else:
        z = False
    return z
trip_advisor_df['Review_Rating_agreement'] = trip_advisor_df.apply(review_rating_agreement, axis=1)

#count total records who set agreement = True
tot_count = 0
for record in trip_advisor_df['Review_Rating_agreement']:
    if record == True:
        tot_count = tot_count + 1

#count how many of each start are in agreement to review
f5_count = 0
f4_count = 0
f3_count = 0
f2_count = 0
f1_count = 0
for record in trip_advisor_df.index:
    if trip_advisor_df['Rating'][record] == 5 and trip_advisor_df['Review_Rating_agreement'][record]  == True:
        f5_count = f5_count + 1
    if trip_advisor_df['Rating'][record] == 4 and trip_advisor_df['Review_Rating_agreement'][record]  == True:
        f4_count = f4_count + 1
    if trip_advisor_df['Rating'][record] == 3 and trip_advisor_df['Review_Rating_agreement'][record]  == True:
        f3_count = f3_count + 1
    if trip_advisor_df['Rating'][record] == 2 and trip_advisor_df['Review_Rating_agreement'][record]  == True:
        f2_count = f2_count + 1
    if trip_advisor_df['Rating'][record] == 1 and trip_advisor_df['Review_Rating_agreement'][record]  == True:
        f1_count = f1_count + 1

#count total of each star
tot_f5_count = 0
tot_f4_count = 0
tot_f3_count = 0
tot_f2_count = 0
tot_f1_count = 0
for record in trip_advisor_df.index:
    if trip_advisor_df['Rating'][record] == 5: 
        tot_f5_count = tot_f5_count + 1
    if trip_advisor_df['Rating'][record] == 4: 
        tot_f4_count = tot_f4_count + 1
    if trip_advisor_df['Rating'][record] == 3: 
        tot_f3_count = tot_f3_count + 1
    if trip_advisor_df['Rating'][record] == 2: 
        tot_f2_count = tot_f2_count + 1
    if trip_advisor_df['Rating'][record] == 1: 
        tot_f1_count = tot_f1_count + 1

#display data
print('TextBlob Analyzer')
print(f'The Total amount of Star to Review Setiment in Agreement is {tot_count} which is {(tot_count/len(trip_advisor_df))*100:2f}%')        
print(f'The Total amount of 5 Star to Review Setiment in Agreement is {f5_count} which is {(f5_count/tot_f5_count)*100:2f}%')
print(f'The Total amount of 4 Star to Review Setiment in Agreement is {f4_count} which is {(f4_count/tot_f4_count)*100:2f}%')
print(f'The Total amount of 3 Star to Review Setiment in Agreement is {f3_count} which is {(f3_count/tot_f3_count)*100:2f}%')
print(f'The Total amount of 2 Star to Review Setiment in Agreement is {f2_count} which is {(f2_count/tot_f2_count)*100:2f}%')
print(f'The Total amount of 1 Star to Review Setiment in Agreement is {f1_count} which is {(f1_count/tot_f1_count)*100:2f}%')        




#NiaveBaynesAnalyzer
tb = Blobber(analyzer=NaiveBayesAnalyzer())
def NB_review_set(df_row):
    data = tb(df_row['Review']).sentiment
    x = data[0]
    return x
trip_advisor_df['NB_Review_Sentiment'] = trip_advisor_df.apply(NB_review_set, axis=1)

w = 'n/a'
def NB_review_rating_agreement(df_row):
    review = df_row['NB_Review_Sentiment']
    rating = df_row['Rating_Sentiment']
    if review == 'pos' and rating == 'Positive':
        w = True
    elif review == 'neg' and rating == 'Negative':
        w = True
    else:
        w = False
    return w
trip_advisor_df['NB_Review_Rating_agreement'] = trip_advisor_df.apply(NB_review_rating_agreement, axis=1)

NB_tot_count = 0
for record in trip_advisor_df['Review_Rating_agreement']:
    if record == True:
        NB_tot_count = NB_tot_count + 1

NB_f5_count = 0
NB_f4_count = 0
NB_f3_count = 0
NB_f2_count = 0
NB_f1_count = 0
for record in trip_advisor_df.index:
    if trip_advisor_df['Rating'][record] == 5 and trip_advisor_df['NB_Review_Rating_agreement'][record]  == True:
        NB_f5_count = NB_f5_count + 1
    if trip_advisor_df['Rating'][record] == 4 and trip_advisor_df['NB_Review_Rating_agreement'][record]  == True:
        NB_f4_count = NB_f4_count + 1
    if trip_advisor_df['Rating'][record] == 3 and trip_advisor_df['NB_Review_Rating_agreement'][record]  == True:
        NB_f3_count = NB_f3_count + 1
    if trip_advisor_df['Rating'][record] == 2 and trip_advisor_df['NB_Review_Rating_agreement'][record]  == True:
        NB_f2_count = NB_f2_count + 1
    if trip_advisor_df['Rating'][record] == 1 and trip_advisor_df['NB_Review_Rating_agreement'][record]  == True:
        NB_f1_count = NB_f1_count + 1

#count total of each star
NB_tot_f5_count = 0
NB_tot_f4_count = 0
NB_tot_f3_count = 0
NB_tot_f2_count = 0
NB_tot_f1_count = 0
for record in trip_advisor_df.index:
    if trip_advisor_df['Rating'][record] == 5: 
        NB_tot_f5_count = NB_tot_f5_count + 1
    if trip_advisor_df['Rating'][record] == 4: 
        NB_tot_f4_count = NB_tot_f4_count + 1
    if trip_advisor_df['Rating'][record] == 3: 
        NB_tot_f3_count = NB_tot_f3_count + 1
    if trip_advisor_df['Rating'][record] == 2: 
        NB_tot_f2_count = NB_tot_f2_count + 1
    if trip_advisor_df['Rating'][record] == 1: 
        NB_tot_f1_count = NB_tot_f1_count + 1

#Display Output
print("NaiveBaynes Analyzer")
print(f'The Total amount of Star to Review Setiment in Agreement is {NB_tot_count} which is {(NB_tot_count/len(trip_advisor_df))*100:2f}%')        
print(f'The Total amount of 5 Star to Review Setiment in Agreement is {NB_f5_count} which is {(NB_f5_count/NB_tot_f5_count)*100:2f}%')
print(f'The Total amount of 4 Star to Review Setiment in Agreement is {NB_f4_count} which is {(NB_f4_count/NB_tot_f4_count)*100:2f}%')
print(f'The Total amount of 3 Star to Review Setiment in Agreement is {NB_f3_count} which is {(NB_f3_count/NB_tot_f3_count)*100:2f}%')
print(f'The Total amount of 2 Star to Review Setiment in Agreement is {NB_f2_count} which is {(NB_f2_count/NB_tot_f2_count)*100:2f}%')
print(f'The Total amount of 1 Star to Review Setiment in Agreement is {NB_f1_count} which is {(NB_f1_count/NB_tot_f1_count)*100:2f}%') 


#WHICH DO I THINK WAS BETTER
#I thought that the Naive was easier to use and coming with setiment as pos or neg made it so I was able to skip a step, But statically speaking the Textblob was more accurate.
#If I had to pick one I would go with Textblob, becasue it worked best with the dataset provided




